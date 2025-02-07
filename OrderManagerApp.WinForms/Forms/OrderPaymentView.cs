using OrderManagerApp.Domain.Models;
using OrderManagerApp.Presenter.Interfaces;
using OrderManagerApp.WinForms.Interfaces;

namespace OrderManagerApp.WinForms.Forms
{
    public partial class OrderPaymentView : Form, IOrderPaymentView
    {
        private readonly IOrderPaymentPresenter _presenter;

        public OrderPaymentView(IOrderPaymentPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            var orders = _presenter.FillData();
            orderDataGrid.DataSource = orders;
        }

        public void SetMoneyArrivals(IEnumerable<MoneyArrival> arrivals)
        {
            arrivalDataGrid.DataSource = arrivals;
        }

        public void SetOrders(IEnumerable<Order> orders)
        {
            orderDataGrid.DataSource = orders;
        }

        public void SetPayments(IEnumerable<Payment> payments)
        {
            paymentsDataGrid.DataSource = payments;
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        private void payButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
