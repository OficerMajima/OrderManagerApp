using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllOrdersAsync();
    }
}
