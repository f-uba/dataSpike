namespace dataSpike
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.henrikdev.xyz");

            var response = await client.GetAsync("valorant/v1/account/fuba/joao");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
    }
}