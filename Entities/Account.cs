using Newtonsoft.Json;

namespace Entities
{
    public class Account
    {
        [JsonProperty("status")]
        public long Status { get; private set; }

        [JsonProperty("data")]
        public Data data { get; private set; }

        public partial class Data
        {
            [JsonProperty("puuid")]
            public Guid Puuid { get; private set; }

            [JsonProperty("region")]
            public string Region { get; private set; }

            [JsonProperty("account_level")]
            public long AccountLevel { get; private set; }

            [JsonProperty("name")]
            public string Name { get; private set; }

            [JsonProperty("tag")]
            public string Tag { get; private set; }

            [JsonProperty("card")]
            public Card Card { get; private set; }

            [JsonProperty("last_update")]
            public string LastUpdate { get; private set; }
        }

        public partial class Card
        {
            [JsonProperty("small")]
            public Uri Small { get; private set; }

            [JsonProperty("large")]
            public Uri Large { get; private set; }

            [JsonProperty("wide")]
            public Uri Wide { get; private set; }

            [JsonProperty("id")]
            public Guid Id { get; private set; }
        }

        public override string ToString()
        {
            return $"Status:{Status}\n" +
                $"Puuid:{data.Puuid}\n" +
                $"Region:{data.Region}\n" +
                $"Level:{data.AccountLevel}\n" +
                $"Name:{data.Name}\n" +
                $"Tag:{data.Tag}\n" +
                $"Small Card:{data.Card.Small}\n" +
                $"Large Card:{data.Card.Large}\n" +
                $"Wide Card:{data.Card.Wide}\n" +
                $"Card Id:{data.Card.Id}\n" +
                $"Last Update:{data.LastUpdate}";
        }
    }
}