using OrderManagerApp.Domain.Models;

namespace OrderManagerApp.Presenter.Interfaces
{
    public interface IOrderPaymentPresenter
    {
        Task Run();
        Task UpdateOrderPayment();
        Task ShowPaymentForm();
    }
}
