using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagerApp.Domain.Models;


namespace OrderManagerApp.Presenter.Interfaces
{
    public interface IOrderPaymentPresenter
    {
        Task FillData();
        Task CreatePayment(Payment payment);
    }
}
