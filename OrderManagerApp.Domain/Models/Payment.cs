using System.ComponentModel.DataAnnotations;

namespace OrderManagerApp.Domain.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int ArrivalId { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
