using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Presenter.Interfaces
{
    public interface IViewPayForm
    {
        void Show();
        void Close();
        Payment Payment { get; set; }
        int ArrivalId { get; set; }
        int OrderId { get; set; }
        decimal PaymentAmount { get; set; }
        public event PayFormOkButtonHandler onPayFormOkClick;
        public delegate Task PayFormOkButtonHandler();
    }
}
