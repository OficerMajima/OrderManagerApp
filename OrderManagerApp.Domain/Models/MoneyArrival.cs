namespace OrderManagerApp.Domain.Models
{
    public class MoneyArrival
    {
        public int ArrivalId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal RemainingAmount { get; set; }
    }
}
