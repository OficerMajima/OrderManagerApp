using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Presenter.Interfaces;
using System.Text.Json;

namespace OrderManagerApp.Presenter.Presenters
{
    public class OrderPaymentPresenter : IOrderPaymentPresenter
    {
        public OrderPaymentPresenter(
            IOrderRepository repository, 
            IMoneyArrivalRepository moneyArrivalRepository,
            IPaymentRepository paymentRepository,
            IServiceProvider serviceProvider,
            IViewOrderPayment view
            )
        {
            this._orderRepository = repository;
            this._moneyArrivalRepository = moneyArrivalRepository;
            this._paymentRepository = paymentRepository;
            this._serviceProvider = serviceProvider;
            this._view = view;
            _view.onPayButtonClickWindow += async () =>
            {
                await ShowPaymentForm();
            };
        }

        private readonly IOrderRepository _orderRepository;
        private readonly IMoneyArrivalRepository _moneyArrivalRepository;
        private readonly IPaymentRepository _paymentRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IViewOrderPayment _view;

        public async Task UpdateOrderPayment()
        {
            try
            {
                _view.SetOrders(await _orderRepository.GetAllOrdersAsync());
                _view.SetPayments(await _paymentRepository.GetAllPaymentsAsync());
                _view.SetMoneyArrivals(await _moneyArrivalRepository.GetAllMoneyArrivalsAsync());
            }
            catch (Exception ex)
            {
                _view.ShowMessage(JsonSerializer.Serialize(ex));
                throw;
            }
        }

        public async Task ShowPaymentForm()
        {
            try
            {
                var payForm = _serviceProvider.GetRequiredService<IViewPayForm>();
                payForm.OrderId = _view.ChosenOrderId;
                payForm.ArrivalId = _view.ChosenArrivalId;
                payForm.onPayFormOkClick += async () =>
                {
                    await AddPayment(payForm);
                };
                payForm.Show();
            }
            catch (ArgumentException ex)
            {
                _view.ShowMessage(ex.Message);
            }
            catch (Exception ex)
            {
                _view.ShowMessage(ex.Message);
            }
        }
        private async Task AddPayment(IViewPayForm payForm)
        {
            try
            {
                await _paymentRepository.AddPayment(payForm.Payment);
                payForm.Close();
            }
            catch (DbUpdateException ex)
            {
                _view.ShowMessage(ex.InnerException!.Message);
                payForm.Close();
            }

            await UpdateOrderPayment();
        }
        public async Task Run()
        {
            await UpdateOrderPayment();
            _view.Show();
        } 
    }
}
