using Microsoft.EntityFrameworkCore;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderManagerDbContext _context;

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
