using Newtonsoft.Json;

namespace Entities
{
    public class Card
    {
        [JsonProperty("id")]
        public Guid? Id { get; private set; }

        [JsonProperty("small")]
        public Uri? Small { get; private set; }

        [JsonProperty("large")]
        public Uri? Large { get; private set; }

        [JsonProperty("wide")]
        public Uri? Wide { get; private set; }

        public Card(Guid id, Uri small, Uri large, Uri wide)
        {
            Id = id;
            Small = small;
            Large = large;
            Wide = wide;
        }

        public Guid GetId() => (Guid)Id;
        public Uri GetSmallCard() => Small;
        public Uri GetLargeCard() => Large;
        public Uri GetWideCard() => Wide;

        public override string ToString()
        {
            return $"Card_Id:{GetId()}\n" +
                $"Card_Small:{GetSmallCard()}\n" +
                $"Card_Large:{GetLargeCard()}\n" +
                $"Card_Wide:{GetWideCard()}";
        }
    }
}
