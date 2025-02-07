using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Interfaces
{
    public interface IPaymentRepository
    {
        Task<IEnumerable<Payment>> GetAllPaymentsAsync();
        Task AddPayment(Payment payment);
    }
}
