using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Repositories
{
    public class MoneyArrivalRepository : IMoneyArrivalRepository
    {
        private OrderManagerDbContext _context;
        private readonly IConfiguration _config;
        private readonly ILogger<MoneyArrivalRepository> _logger;

        public MoneyArrivalRepository(IConfiguration config, ILogger<MoneyArrivalRepository> logger)
        {
            this._config = config;
            this._logger = logger;
        }

        public async Task<IEnumerable<MoneyArrival>> GetAllMoneyArrivalsAsync()
        {
            _context = new OrderManagerDbContext(_config);
            var moneyArrivals = _context.MoneyArrivals.ToList();
            _context.Dispose();
            _logger.LogInformation("Данные из таблицы MoneyArrivals получены");
            return moneyArrivals;
        }
    }
}
