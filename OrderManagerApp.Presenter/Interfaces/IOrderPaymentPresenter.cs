using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagerApp.Presenter.Interfaces
{
    public interface IOrderPaymentPresenter
    {
        Task LoadOrders();
        Task LoadArrivals();
        Task LoadPayments();
    }
}
