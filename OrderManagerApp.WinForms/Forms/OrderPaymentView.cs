using OrderManagerApp.Domain.Models;
using OrderManagerApp.WinForms.Interfaces;

namespace OrderManagerApp.WinForms.Forms
{
    public partial class OrderPaymentView : Form, IViewOrderPayment
    {
        public event IViewOrderPayment.ExitWindowHandler onCloseWindow;

        public event IViewOrderPayment.PayFormHandler onPayButtonClickWindow;

        public OrderPaymentView()
        {
            InitializeComponent();
        }

        public int ChosenOrderId 
        {
            get
            {
                if (orderDataGrid.SelectedRows.Count <= 0) throw new ArgumentException("Не выбран заказ");
                return int.Parse(orderDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        public int ChosenArrivalId
        {
            get
            {
                if (arrivalDataGrid.SelectedRows.Count <= 0) throw new ArgumentException("Не выбран приход");
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
            arrivalDataGrid.Columns["ArrivalId"].HeaderText = "Номер";
            arrivalDataGrid.Columns["ArrivalDate"].HeaderText = "Дата";
            arrivalDataGrid.Columns["TotalAmount"].HeaderText = "Сумма";
            arrivalDataGrid.Columns["RemainingAmount"].HeaderText = "Остаток";
        }

        public void SetOrders(IEnumerable<Order> orders)
        {
            orderDataGrid.DataSource = orders;
            orderDataGrid.Columns["OrderId"].HeaderText = "Номер";
            orderDataGrid.Columns["OrderDate"].HeaderText = "Дата";
            orderDataGrid.Columns["TotalAmount"].HeaderText = "Сумма";
            orderDataGrid.Columns["AmountPaid"].HeaderText = "Оплачено";
        }

        public void SetPayments(IEnumerable<Payment> payments)
        {
            paymentsDataGrid.DataSource = payments;
            paymentsDataGrid.Columns["PaymentId"].HeaderText = "Номер";
            paymentsDataGrid.Columns["OrderId"].HeaderText = "№аказ";
            paymentsDataGrid.Columns["ArrivalId"].HeaderText = "Приход";
            paymentsDataGrid.Columns["PaymentAmount"].HeaderText = "Сумма";
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
