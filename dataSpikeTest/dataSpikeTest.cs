using Client;
using Entities;
using Newtonsoft.Json;

namespace dataSpike
{
    class Program
    {
        private static ValorantClient valorantClient = new("fuba", "joao");

        async static Task Main(string[] args)
        {
            var account = await valorantClient.GetAccountAsync();
            Console.WriteLine(account.ToString());
        }
    }
}