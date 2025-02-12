﻿using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.Domain.Models;
using OrderManagerApp.Presenter.Interfaces;

namespace OrderManagerApp.Presenter.Presenters
{
    public class OrderPaymentPresenter : IOrderPaymentPresenter
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMoneyArrivalRepository _moneyArrivalRepository;
        private readonly IPaymentRepository _paymentRepository;
        private readonly OrderPaymentView _view;

        public OrderPaymentPresenter(
            IOrderRepository orderRepository,
            IMoneyArrivalRepository moneyArrivalRepository,
            IPaymentRepository paymentRepository,
            OrderPaymentView view)
        {
            _orderRepository = orderRepository;
            _moneyArrivalRepository = moneyArrivalRepository;
            _paymentRepository = paymentRepository;
            _view = view;
        }

        public Task CreatePayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public async Task FillData()
        {
            var orders = await _orderRepository.GetAllOrdersAsync();
            var arrivals = await _moneyArrivalRepository.GetAllMoneyArrivalsAsync();
            var payment = await _paymentRepository.GetAllPaymentsAsync();

            _view.SetOrders(orders);
            _view.SetMoneyArrivals(arrivals);
            _view.SetPayments(payment);
        }
    }
}
