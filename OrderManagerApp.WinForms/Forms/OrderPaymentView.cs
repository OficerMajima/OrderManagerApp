using OrderManagerApp.Domain.Models;
using OrderManagerApp.Presenter.Interfaces;

namespace OrderManagerApp.WinForms.Forms
{
    public partial class OrderPaymentView : Form, IViewOrderPayment
    {
        public OrderPaymentView(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private readonly IServiceProvider _serviceProvider;

        public event IViewOrderPayment.ExitWindowHandler onCloseWindow;
        public delegate void ExitWindowHandler();

        public event IViewOrderPayment.PayFormHandler onPayButtonClickWindow;
        public delegate Task PayFormHandler();

        public int ChosenOrderId
        {
            get
            {
                if (orderDataGrid.SelectedRows.Count <= 0) throw new ArgumentException("No order selected");
                return int.Parse(orderDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        public int ChosenArrivalId
        {
            get
            {
                if (arrivalDataGrid.SelectedRows.Count <= 0) throw new ArgumentException("No arrival selected");
                return int.Parse(arrivalDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        public new void Show()
        {
            Application.Run(this);
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
            MessageBox.Show(message);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            onPayButtonClickWindow.Invoke();
        }
    }
}
