namespace App06
{
    public class Pipeline<TInput, TOutput> : IPipeline<TInput, TOutput>
        where TInput : BaseRequest
        where TOutput : IDisposable, new()
    {
        public TOutput ExecuteTask(TInput request)
        {
            var response = new TOutput();
            Console.WriteLine($"The request {request} returns the response {response}");
            return response;
        }
    }
}
