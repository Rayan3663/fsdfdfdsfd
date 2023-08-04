using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace foodOrderingSystem.models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        [JsonIgnore]
        public List<Products> Products { get; set; }
        [JsonIgnore]
        public Users Users { get; set; }

        public Payment Payment { get; set; }
    }
}
