using Newtonsoft.Json;

namespace Entities
{
    public class MMR
    {
        [JsonProperty("status")]
        private long Status { get; set; }

        [JsonProperty("data")]
        private Data Info { get; set; }

        public partial class Data
        {
            [JsonProperty("currenttier")]
            public long CurrentTier { get; private set; }

            [JsonProperty("currenttierpatched")]
            public string CurrentTierPatched { get; private set; }

            [JsonProperty("ranking_in_tier")]
            public long RankingInTier { get; private set; }

            [JsonProperty("mmr_change_to_last_game")]
            public long MmrChangeToLastGame { get; private set; }

            [JsonProperty("elo")]
            public long Elo { get; private set; }
        }

        public long GetStatus() => Status;
        public long GetCurrentTier() => Info.CurrentTier;
        public string GetCurrentTierPatched() => Info.CurrentTierPatched;
        public long GetRankingInTier() => Info.RankingInTier;
        public long GetMmrChangeToLastGame() => Info.MmrChangeToLastGame;
        public long GetElo() => Info.Elo;

        public override string ToString()
        {
            return $"MMR_Status:{GetStatus()}\n" +
                $"MMR_CurrentTier:{GetCurrentTier()}\n" +
                $"MMR_CurrentTierPatched:{GetCurrentTierPatched()} \n" +
                $"MMR_RankingInTier:{GetRankingInTier()} \n" +
                $"MMR_MmrChangeToLastGame:{GetMmrChangeToLastGame()} \n" +
                $"MMR_Elo:{GetElo()}";
        }
    }
}
