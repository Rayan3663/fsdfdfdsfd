using System.ComponentModel.DataAnnotations.Schema;

namespace foodOrderingSystem.models
{
    public class Payment
    {
        public int Id { get; set; }
        public double TotalCost { get; set; }
        [ForeignKey("Users")]
        public int UserID { get; set; }
        public Users Users { get; set; }
        [ForeignKey("OrderDetails")]
        public int OrderID { get; set; }
        public OrderDetails OrderDetails { get; set; }
    }
}
