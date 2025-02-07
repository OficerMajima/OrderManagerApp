using System.ComponentModel.DataAnnotations;

namespace OrderManagerApp.Domain.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
