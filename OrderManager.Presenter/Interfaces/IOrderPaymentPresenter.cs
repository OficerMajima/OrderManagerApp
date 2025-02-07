using OrderManagerApp.Domain.Models;


namespace OrderManagerApp.Presenter.Interfaces
{
    public interface IOrderPaymentPresenter
    {
        Task<IEnumerable<Order>> FillData();
        Task CreatePayment(Payment payment);
    }
}
