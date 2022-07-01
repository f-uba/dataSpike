using Entities;
using Newtonsoft.Json;

namespace Client
{
    public class ValorantClient
    {
        
        private const string baseUri = "https://api.henrikdev.xyz";
        private const string route = "valorant";
        private const string version1 = "v1";
        private const string version2 = "v2";
        private const string version3 = "v3";

        public static string Name { get; private set; }
        public static string Tag { get; private set; }

        public ValorantClient(string name, string tag)
        {
            Name = name;
            Tag = tag;
        }

        public async Task<Account> GetAccountAsync()
        {
            HttpClient client = new();
            client.BaseAddress = new Uri(baseUri);

            var response = await client.GetAsync($"{route}/{version1}/account/{Name}/{Tag}");
            var content = await response.Content.ReadAsStringAsync();
            var account = JsonConvert.DeserializeObject<Account>(content);

            account.SetMMR(await GetMMRAsync(account.GetRegion()));

            return account;
        }

        private async Task<MMR> GetMMRAsync(string region)
        {
            HttpClient client = new();
            client.BaseAddress = new Uri(baseUri);

            var response = await client.GetAsync($"{route}/{version1}/mmr/{region}/{Name}/{Tag}");
            var content = await response.Content.ReadAsStringAsync();
            var mmr = JsonConvert.DeserializeObject<MMR>(content);

            return mmr;
        }
    }
}