using Entities;
using Newtonsoft.Json;

namespace dataSpike
{
    class Program
    {
        private static HttpClient client = new();

        private static readonly string baseUri = "https://api.henrikdev.xyz";
        private static readonly string route = "valorant";

        private static readonly string name = "fuba";
        private static readonly string gameTag = "joao";
        private static readonly string region = "na";

        private static readonly string v1 = "v1";
        private static readonly string v2 = "v2";
        private static readonly string v3 = "v3";

        static async Task Main(string[] args)
        {
            Console.WriteLine(await GetAccountAsync());
        }

        public async static Task<string> GetAccountAsync()
        {       
            client.BaseAddress = new Uri(baseUri);
            var response = await client.GetAsync($"{route}/{v1}/account/{name}/{gameTag}");
            var content = await response.Content.ReadAsStringAsync();
            var account = JsonConvert.DeserializeObject<Account>(content);
            return account != null? account.ToString() : "Account object returned null.";
        }
    }
}