﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OrderManagerApp.Domain.Interfaces;
using OrderManagerApp.WinForms.Interfaces;
using System.Text.Json;

namespace OrderManagerApp.WinForms.Presenters
{
    public class OrderPaymentPresenter : IOrderPaymentPresenter
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMoneyArrivalRepository _moneyArrivalRepository;
        private readonly IPaymentRepository _paymentRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IViewOrderPayment _view;
        private readonly ILogger<OrderPaymentPresenter> _logger;

        public OrderPaymentPresenter(
            IOrderRepository repository, 
            IMoneyArrivalRepository moneyArrivalRepository,
            IPaymentRepository paymentRepository,
            IServiceProvider serviceProvider,
            IViewOrderPayment view,
            ILogger<OrderPaymentPresenter> logger
            )
        {
            this._orderRepository = repository;
            this._moneyArrivalRepository = moneyArrivalRepository;
            this._paymentRepository = paymentRepository;
            this._serviceProvider = serviceProvider;
            this._logger = logger;
            this._view = view;
            _view.onPayButtonClickWindow += async () =>
            {
                await ShowPaymentForm();
            };
        }

        public async Task UpdateOrderPayment()
        {
            try
            {
                _view.SetOrders(await _orderRepository.GetAllOrdersAsync());
                _view.SetPayments(await _paymentRepository.GetAllPaymentsAsync());
                _view.SetMoneyArrivals(await _moneyArrivalRepository.GetAllMoneyArrivalsAsync());
                _logger.LogInformation("Таблицы обновлены успешно.");
            }
            catch (Exception ex)
            {
                _view.ShowMessage(JsonSerializer.Serialize(ex));
                _logger.LogError("Произошла ошибка во время обновления таблиц Ошибка {ex}", ex.Message);
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
                _logger.LogInformation("Форма для оплаты создана.");
                payForm.Show();
            }
            catch (ArgumentException ex)
            {
                _logger.LogError("Произошла ошибка во время создания формы Ошибка {ex}", ex.Message);
                _view.ShowMessage(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError("Произошла ошибка во время создания формы Ошибка {ex}", ex.Message);
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
                _logger.LogError("Произошла ошибка при добавлении платежа. Ошибка {ex}", ex.Message);
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
