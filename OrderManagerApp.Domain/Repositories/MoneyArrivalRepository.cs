using Microsoft.EntityFrameworkCore;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class MoneyArrivalRepository : IMoneyArrivalRepository
    {
        private readonly OrderManagerDbContext _context;

        public MoneyArrivalRepository(OrderManagerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MoneyArrival>> GetAllMoneyArrivalsAsync()
        {
            return await _context.MoneyArrivals.ToListAsync();
        }
    }
}
