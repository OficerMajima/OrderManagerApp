using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Presenter.Interfaces
{
    public interface IViewOrderPayment 
    {
        void Show();
        void Close();
        void SetOrders(IEnumerable<Order> orders);
        void SetMoneyArrivals(IEnumerable<MoneyArrival> arrivals);
        void SetPayments(IEnumerable<Payment> payments);
        void ShowMessage(string message);

        int ChosenOrderId {  get; }
        int ChosenArrivalId { get; }

        public event ExitWindowHandler onCloseWindow;
        public delegate void ExitWindowHandler();

        public event PayFormHandler onPayButtonClickWindow;
        public delegate Task PayFormHandler();
    }
}
