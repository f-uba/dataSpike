using Newtonsoft.Json;

namespace Entities
{
    public partial class Matches
    {
        [JsonProperty("status")]
        private long Status { get; set; }

        [JsonProperty("data")]
        private List<Match>? Data { get; set; }

        public long GetStatus() => Status;
        public List<Match> GetMatches() => Data;

        public override string ToString()
        {
            string toString = $"Status: {GetStatus()}\n";         
            if (Data != null) foreach (Match match in Data) toString += match.ToString();

            return toString;
        }
    }
}

