using Newtonsoft.Json;

namespace Entities
{
    public class Player
    {
        [JsonProperty("puuid")]
        private Guid Puuid { get; set; }

        [JsonProperty("character")]
        private string? Character { get; set; }

        [JsonProperty("ability_casts")]
        private AbilityCast? AbilityCasts { get; set; }

        [JsonProperty("stats")]
        private Stats Stat { get; set; }

        [JsonProperty("economy")]
        private Economy Eco { get; set; }

        [JsonProperty("damage_made")]
        private long DamageMade { get; set; }

        [JsonProperty("damage_received")]
        private long DamageReceived { get; set; }

        public partial class AbilityCast
        {
            [JsonProperty("c_cast")]
            public long? C { get; private set; }

            [JsonProperty("q_cast")]
            public long? Q { get; private set; }

            [JsonProperty("e_cast")]
            public long? E { get; private set; }

            [JsonProperty("x_cast")]
            public long? X { get; private set; }

            public override string ToString()
            {
                return $"C Cast: {C}\n" +
                    $"Q Cast: {Q}\n" +
                    $"E Cast: {E}\n" +
                    $"X Cast: {X}\n";
            }
        }

        public partial class Stats
        {
            [JsonProperty("score")]
            public long Score { get; private set; }

            [JsonProperty("kills")]
            public long Kills { get; private set; }

            [JsonProperty("deaths")]
            public long Deaths { get; private set; }

            [JsonProperty("assists")]
            public long Assists { get; private set; }

            [JsonProperty("bodyshots")]
            public long Bodyshots { get; private set; }

            [JsonProperty("headshots")]
            public long Headshots { get; private set; }

            [JsonProperty("legshots")]
            public long Legshots { get; private set; }

            public override string ToString()
            {
                return $"Score: {Score}\n" +
                    $"Kills: {Kills}\n" +
                    $"Deaths: {Deaths}\n" +
                    $"Assists: {Assists}\n" +
                    $"Bodyshots: {Bodyshots}\n" +
                    $"Headshots: {Headshots}\n" +
                    $"Legshots: {Legshots}\n";
            }
        }

        public partial class Economy
        {
            [JsonProperty("spent")]
            public Value Spent { get; private set; }

            [JsonProperty("loadout_value")]
            public Value LoadoutValue { get; private set; }

            public override string ToString()
            {
                return $"Spent: {Spent.ToString()}\n" +
                    $"Loadout Value: {LoadoutValue.ToString()}\n";
            }
        }

        public partial class Value
        {
            [JsonProperty("overall")]
            public long Overall { get; private set; }

            [JsonProperty("average")]
            public long Average { get; private set; }

            public override string ToString()
            {
                return $"Overall({Overall}) Average({Average})";
            }
        }

        public Guid GetPuuid() => Puuid;
        public string GetCharacter() => Character;
        public long GetCCast() => (long)AbilityCasts.C;
        public long GetQCast() => (long)AbilityCasts.Q;
        public long GetECast() => (long)AbilityCasts.E;
        public long GetXCast() => (long)AbilityCasts.X;
        public long GetScore() => Stat.Score;
        public long GetKills() => Stat.Kills;
        public long GetDeaths() => Stat.Deaths;
        public long GetAssists() => Stat.Assists;
        public long GetBodyshots() => Stat.Bodyshots;
        public long GetHeadshots() => Stat.Headshots;
        public long GetLegshots() => Stat.Legshots;
        public long GetSpentOverall() => Eco.Spent.Overall;
        public long GetSpentAverage() => Eco.Spent.Average;
        public long GetLoadoutValueOverall() => Eco.LoadoutValue.Overall;
        public long GetLoadoutValueAverage() => Eco.LoadoutValue.Average;
        public long GetDamageMade() => DamageMade;
        public long GetDamageReceived() => DamageReceived;


        public override string ToString()
        {
            return $"=== Puuid {GetPuuid()} ===\n" +
                $"Character: {Character}\n" +
                $"{AbilityCasts.ToString()}" +
                $"{Stat.ToString()}" +
                $"{Eco.ToString()}" +
                $"Damage Made: {GetDamageMade()}\n" +
                $"Damage Received: {GetDamageReceived()}\n";
        }
    }
}
