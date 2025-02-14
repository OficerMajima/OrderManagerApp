using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private OrderManagerDbContext _context;
        private readonly IConfiguration _config;
        private readonly ILogger<PaymentRepository> _logger;

        public PaymentRepository(IConfiguration config, ILogger<PaymentRepository> logger)
        {
            this._config = config;
            this._logger = logger;
        }

        public async Task AddPayment(Payment payment)
        {
            _context = new OrderManagerDbContext(this._config);
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            _context.Dispose();
            _logger.LogInformation("Платёж добавлен в таблицу Payments. Платеж {payment}", payment);
        }

        public async Task<IEnumerable<Payment>> GetAllPaymentsAsync()
        {
            _context = new OrderManagerDbContext(this._config);
            var payments = _context.Payments.ToList();
            _context.Dispose();
            _logger.LogInformation("Данные из таблицы Payments получены.");
            return payments;
        }
    }
}
