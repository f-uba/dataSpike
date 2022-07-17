using Newtonsoft.Json;

namespace Entities
{
    public class Account
    {
        [JsonProperty("status")]
        private long Status { get; set; }

        [JsonProperty("data")]
        private Data? Info { get; set; }

        private MMR MMR { get; set; }

        private Matches Matches { get; set; }

        public partial class Data
        {
            [JsonProperty("puuid")]
            public Guid? Puuid { get; private set; }

            [JsonProperty("region")]
            public string? Region { get; private set; }

            [JsonProperty("account_level")]
            public long? Level { get; private set; }

            [JsonProperty("name")]
            public string? Name { get; private set; }

            [JsonProperty("tag")]
            public string? Tag { get; private set; }

            [JsonProperty("card")]
            public Card? Card { get; private set; }

            [JsonProperty("last_update")]
            public string? LastUpdate { get; private set; }
        }

        public long GetStatus() => Status;
        public Guid GetPuuid() => (Guid)Info.Puuid;
        public string GetRegion() => Info.Region;
        public long GetLevel() => (long)Info.Level;
        public string GetName() => Info.Name;
        public string GetTag() => Info.Tag;
        public Card GetCard() => new Card((Guid)Info.Card.Id, Info.Card.Small, Info.Card.Large, Info.Card.Wide);
        public string GetLastUpdate() => Info.LastUpdate;
        public MMR GetMMR() => MMR;
        public Matches GetMatches() => Matches;

        public void SetMMR(MMR mmr) { MMR = mmr; }

        public void SetMatches(Matches matches) { Matches = matches; }

        public override string ToString()
        {
            return $"Status:{GetStatus()}\n" +
                $"Puuid:{GetPuuid()}\n" +
                $"Region:{GetRegion()}\n" +
                $"Level:{GetLevel()}\n" +
                $"Name:{GetName()}\n" +
                $"Tag:{GetTag()}\n" +
                $"Last Update:{GetLastUpdate()}\n" +
                $"{GetCard().ToString()}\n" +
                $"{GetMMR().ToString()}\n" +
                $"{GetMatches().ToString()}";
        }
    }
}
