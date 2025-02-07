using Microsoft.EntityFrameworkCore;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderManagerDbContext _context;

        public OrderRepository(OrderManagerDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); // Проверка на null
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            var orders = await _context.Orders.ToListAsync();
            return orders;
        }
    }
}
