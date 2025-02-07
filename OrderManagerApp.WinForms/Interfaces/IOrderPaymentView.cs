using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.WinForms.Interfaces
{
    public interface IOrderPaymentView
    {
        void SetOrders(IEnumerable<Order> orders);
        void SetMoneyArrivals(IEnumerable<MoneyArrival> arrivals);
        void SetPayments(IEnumerable<Payment> payments);
        void ShowMessage(string message);
    }
}
