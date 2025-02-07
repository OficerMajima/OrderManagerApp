using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public PaymentRepository(IConfiguration config)
        {
            this._config = config;
        }

        private OrderManagerDbContext _context;
        private readonly IConfiguration _config;

        public async Task AddPayment(Payment payment)
        {
            _context = new OrderManagerDbContext(this._config);
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            _context.Dispose();
        }

        public async Task<IEnumerable<Payment>> GetAllPaymentsAsync()
        {
            _context = new OrderManagerDbContext(this._config);
            var payments = _context.Payments.ToList();
            _context.Dispose();
            return payments;
        }
    }
}
