using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository(IConfiguration config)
        {
            this._config = config;
        }

        private OrderManagerDbContext _context;
        private readonly IConfiguration _config;

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            _context = new OrderManagerDbContext(_config);
            var orders = _context.Orders.ToList();
            _context.Dispose();
            return orders;
        }
    }
}
