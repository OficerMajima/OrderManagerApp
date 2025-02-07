using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Interfaces
{
    public interface IMoneyArrivalRepository
    {
        Task<IEnumerable<MoneyArrival>> GetAllMoneyArrivalsAsync();
    }
}
