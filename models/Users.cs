using System.Text.Json.Serialization;

namespace foodOrderingSystem.models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Products> Products { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
        public Payment Payment { get; set; }
    }
}
