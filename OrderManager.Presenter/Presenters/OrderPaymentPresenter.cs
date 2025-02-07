using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;
using OrderManagerApp.Presenter.Interfaces;

namespace OrderManagerApp.Presenter.Presenters
{
    public class OrderPaymentPresenter : IOrderPaymentPresenter
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMoneyArrivalRepository _moneyArrivalRepository;
        private readonly IPaymentRepository _paymentRepository;
        private readonly IOrderPaymentView _orderPaymentView;

        public OrderPaymentPresenter(
            IOrderRepository orderRepository,
            IMoneyArrivalRepository moneyArrivalRepository,
            IPaymentRepository paymentRepository)
        {
            _orderRepository = orderRepository;
            _moneyArrivalRepository = moneyArrivalRepository;
            _paymentRepository = paymentRepository;
        }

        public Task CreatePayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> FillData()
        {
            var orders = await _orderRepository.GetAllOrdersAsync();
            return orders;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync();
        }
    }
}
