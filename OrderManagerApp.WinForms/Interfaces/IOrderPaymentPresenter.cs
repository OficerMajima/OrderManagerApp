namespace OrderManagerApp.WinForms.Interfaces
{
    public interface IOrderPaymentPresenter
    {
        Task Run();
        Task UpdateOrderPayment();
        Task ShowPaymentForm();
    }
}
