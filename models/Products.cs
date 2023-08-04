using System.Text.Json.Serialization;

namespace foodOrderingSystem.models
{
    public class Products
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [JsonIgnore]
        public Users User { get; set; }
        [JsonIgnore]
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
