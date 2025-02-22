namespace OrderManagerApp.WinForms.Interfaces
{
    public interface IOrderPaymentPresenter
    {
        Task Run();
        Task InitOrderPayment();
        Task ShowPaymentForm();
    }
}
