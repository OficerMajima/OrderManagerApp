using Microsoft.Extensions.Configuration;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class MoneyArrivalRepository : IMoneyArrivalRepository
    {
        public MoneyArrivalRepository(IConfiguration config)
        {
            this._config = config;
        }

        private OrderManagerDbContext _context;
        private readonly IConfiguration _config;

        public async Task<IEnumerable<MoneyArrival>> GetAllMoneyArrivalsAsync()
        {
            _context = new OrderManagerDbContext(_config);
            var moneyArrivals = _context.MoneyArrivals.ToList();
            _context.Dispose();
            return moneyArrivals;
        }
    }
}
