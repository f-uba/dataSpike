using Newtonsoft.Json;

namespace Entities
{
    public class Match
    {
        [JsonProperty("metadata")]
        private Metadata Data { get; set; }

        [JsonProperty("players")]
        private Contender Players { get; set; }

        public partial class Metadata
        {
            [JsonProperty("matchid")]
            public Guid Matchid { get; private set; }

            [JsonProperty("map")]
            public string Map { get; private set; }

            [JsonProperty("game_start_patched")]
            public string GameStartPatched { get; private set; }

            [JsonProperty("rounds_played")]
            public long RoundsPlayed { get; private set; }

            [JsonProperty("mode")]
            public string Mode { get; private set; }
        }

        public partial class Contender
        {
            [JsonProperty("all_players")]
            public List<Player> AllPlayers { get; private set; }

            public override string ToString()
            {
                string toString = $"=== Players ===\n";
                if (this.AllPlayers != null) foreach (Player player in AllPlayers) toString += player.ToString();

                return toString;
            }
        }

        public Guid GetMatchId() => Data.Matchid;
        public string GetMap() => Data.Map;
        public string GetGameStartPatched() => Data.GameStartPatched;
        public long GetRoundsPlayed() => Data.RoundsPlayed;
        public string GetMode() => Data.Mode;

        public override string ToString()
        {
            string toString = $"===== Match {GetMatchId()} =====\n" +
                $"Map: {GetMap()}\n" +
                $"Game Start Patched: {GetGameStartPatched()}\n" +
                $"Rounds Played: {GetRoundsPlayed()}\n" +
                $"Mode: {GetMode()}\n" +
                Players.ToString();

            return toString;
        }
    }
}
