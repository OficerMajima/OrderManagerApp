using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private OrderManagerDbContext _context;
        private readonly IConfiguration _config;
        private readonly ILogger<OrderRepository> _logger;

        public OrderRepository(IConfiguration config, ILogger<OrderRepository> logger)
        {
            this._config = config;
            this._logger = logger;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            _context = new OrderManagerDbContext(_config);
            var orders = _context.Orders.ToList();
            _context.Dispose();
            _logger.LogInformation("Данные из таблицы Orders получены.");
            return orders;
        }
    }
}
