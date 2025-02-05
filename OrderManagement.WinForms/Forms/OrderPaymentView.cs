using OrderManagerApp.Domain.Models;
using OrderManagerApp.WinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerApp.WinForms.Forms
{
    public partial class OrderPaymentView : Form, IOrderPaymentView
    {

        public OrderPaymentView()
        {
            InitializeComponent();
        }

        public void SetMoneyArrivals(IEnumerable<MoneyArrival> arrivals)
        {
            throw new NotImplementedException();
        }

        public void SetOrders(IEnumerable<Order> orders)
        {
            throw new NotImplementedException();
        }

        public void SetPayments(IEnumerable<Payment> payments)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void payButton_Click(object sender, EventArgs e)
        {

        }
    }
}
