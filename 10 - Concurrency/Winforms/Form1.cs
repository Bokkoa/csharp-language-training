using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Winforms;

public partial class Form1 : Form
{
    private string apiUrl;
    private HttpClient httpClient;
    private CancellationTokenSource cts;

    public Form1()
    {
        InitializeComponent();
        apiUrl = "https://localhost:7276/api";
        httpClient = new HttpClient();
    }

    // the exception of task void is just for event handler
    private async void btnStart_Click(object sender, EventArgs e)
    {

        // UPDATE 6: Cancel the process
        cts = new CancellationTokenSource();

        // UPDATE 9: Cancel by timeout
        cts.CancelAfter(TimeSpan.FromSeconds(5));

        // show loading in percentage on screen
        var progressReport = new Progress<int>(ReportCardProcessingProgress);

        loadingGIF.Visible = true;
        pgCards.Visible = true;

        // this will freeze the UI
        // Thread.Sleep(TimeSpan.FromSeconds(5));

        // this will do the same of up but
        // avoiding ui freezing
        // await means that the thread is free to do other things
        // and then come back when the task finished
        //await Wait();


        var stopWatch = new Stopwatch();

        // UPDATE 1: Communicate with api
        //var name = txtInput.Text;
        try
        {
            // UPDATE 1: Communicate with api

            //var greeting = await GetGreetings(name);
            //MessageBox.Show(greeting);





            // UPDATE 2: Get WhenAll in task

            // AWAIT GetCards and PrcoessCards
            // Free up our UI Thread and avoid
            // load freezing


            // UPDATE 7: Cancel the loop, (adding cancellation token to arguments)
                
            var cards = await GetCards(2500, cts.Token);
            stopWatch.Start();

            await ProcessCards(cards, progressReport, cts.Token);
        }
        // UPDATE 6: Cancel the process
        catch (TaskCanceledException ex)
        {
            MessageBox.Show("Operation was cancel");
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            cts.Dispose();
        }

        // UPDATE 2: Get WhenAll in task
        MessageBox.Show($"Operation done in {stopWatch.ElapsedMilliseconds / 1000.0}");


        // this line is going to be execute
        // immediately if we dont use await operator
        loadingGIF.Visible = false;

        // reset the progress bar
        pgCards.Visible = false;
        pgCards.Value = 0;
    }

    // UPDATE 10 Creating finished tasks for unit testing purposes
    private Task ProcessCardsMock(List<string> cards, IProgress<int> progress = null, CancellationToken token = default)
    {
        // do some process

        return Task.CompletedTask;
    }

    private void ReportCardProcessingProgress(int percentage)
    {
        pgCards.Value = percentage;
    }

    private async Task ProcessCards(List<string> cards, IProgress<int> progress = null, CancellationToken token = default)
    {
        // UPDATE 4: Progress bar
        //var tasksResolved = 0;
        // UPDATE 3: SemaphoreSlim
        using var semaphore = new SemaphoreSlim(1000);

        // await task as a group
        var tasks = new List<Task<HttpResponseMessage>>();

        // avoid UI Freezing or delay
        // run in other thread
        // but await for result
        //await Task.Run(() =>
        //{
        //    foreach (var card in cards)
        //    {

        // UPDATE 3: using LINQ instead of foreach
        tasks = cards.Select(async card =>
        {
            var json = JsonConvert.SerializeObject(card);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // adding task to a list of tasks
            //var responseTask = httpClient.PostAsync($"{apiUrl}/cards", content);
            //tasks.Add(responseTask);
            await semaphore.WaitAsync();
            try
            {
                // ocuping 1 of 4000 semaphore space
                var internalTask = await httpClient.PostAsync($"{apiUrl}/cards", content, token);


                // UPGRADING EACH TIME MAY NOT BE THE BEST OPTION
                //if(progress != null)
                //{
                //    tasksResolved++;

                //    var percentage = (double)tasksResolved / cards.Count;
                //    percentage = percentage * 100;

                //    var percentageInt = (int)Math.Round(percentage, 0);

                //    progress.Report(percentageInt);
                //}

                return internalTask;
            }
            finally
            {
                // release to allow other tasks to be done
                semaphore.Release();
            }

        }).ToList();

        //    }
        //});

        // waiting all the tasks before continue the execution

        // UPDATE 5: Changing await to work in batchs

        var responsesTasks = Task.WhenAll(tasks);

        // UPDATE 5: Run once each second, for better performance
        if (progress != null)
        {
            while (await Task.WhenAny(responsesTasks, Task.Delay(TimeSpan.FromSeconds(1))) != responsesTasks)
            {
                var completedTasks = tasks.Where(x => x.IsCompleted).Count();
                var percentage = (double)completedTasks / tasks.Count;
                percentage = percentage * 100;
                var percentageInt = (int)Math.Round(percentage, 0);
                progress.Report(percentageInt);
            }
        }

        // awaiting a task twice does not run the task twice
        var responses = await responsesTasks;

        var rejectedCards = new List<string>();

        foreach (var res in responses)
        {
            var content = await res.Content.ReadAsStringAsync();
            var responseCard = JsonConvert.DeserializeObject<CardResponse>(content);

            if (!responseCard.Approved)
            {
                rejectedCards.Add(responseCard.Card);
            }

        }

        foreach (var card in rejectedCards)
        {
            Debug.WriteLine($"Card {card} was rejected");
        }

    }

    private async Task<List<string>> GetCards(int amountOfCardsToGenerate, CancellationToken token = default)
    {
        // This will happen
        // on another thread
        return await Task.Run(async () =>
        {
            var cards = new List<string>();

            for (int i = 0; i < amountOfCardsToGenerate; i++)
            {
                // This allow to do something like
                // 0000001
                // 0000002

                // UPDATE 7: Loop cancellation
                await Task.Delay(TimeSpan.FromSeconds(1));

                cards.Add(i.ToString().PadLeft(16, '0'));

                Console.WriteLine($"Card number {i} has been created.");

                // UPDATE 7: Loop cancellation
                if (token.IsCancellationRequested)
                {
                    throw new TaskCanceledException();
                }
            }

            return cards;
        });

    }

    private async Task Wait()
    {
        await Task.Delay(TimeSpan.FromSeconds(0));
    }

    private async Task<string> GetGreetings(string name)
    {
        using (var response = await httpClient.GetAsync($"{apiUrl}/greetings/{name}"))
        {
            var greeting = await response.Content.ReadAsStringAsync();

            return greeting;
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        cts?.Cancel();
    }
}
