using Microsoft.EntityFrameworkCore;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly OrderManagerDbContext _context;

        public PaymentRepository(OrderManagerDbContext context)
        {
            _context = context;
        }

        public async Task AddPayment(Payment payment)
        {
            await _context.Payments.AddAsync(payment);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Payment>> GetAllPaymentsAsync()
        {
            return await _context.Payments.ToListAsync();
        }
    }
}
