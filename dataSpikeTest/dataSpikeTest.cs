using Client;
using Entities.Exceptions;

namespace dataSpike
{
    class Program
    {
        async static Task Main(string[] args)
        {
            try
            {
                string riotId = ""; 
                string tagLine = "";

                Console.WriteLine("Insira seu Riot ID: ");
                riotId = Console.ReadLine();
                Console.WriteLine("Insira sua Tag Line: ");
                tagLine = Console.ReadLine();

                Console.WriteLine();

                ValorantClient valorantClient = new(riotId, tagLine);
                var account = await valorantClient.GetAccountAsync();

                Console.WriteLine(account.ToString());
            }
            catch (StatusCodeException scex)
            {
                Console.WriteLine(scex.Message);
            }
        }
    }
}