

namespace App06
{
    public class ClientProcessor : IProcessor<Client>, ILogger
    {
        public void Process(Client input)
        {
            Console.WriteLine($"Processing client: {input}");
        }

        public static void GenericStaticProcess<TGeneric>(TGeneric input)
        {
            Console.WriteLine($"Executing generic static process {input}");
        }

        public void Log<T>(T input)
        {
            Console.WriteLine($"Executing the void generic method LOG {input}");
        }
    }
}
