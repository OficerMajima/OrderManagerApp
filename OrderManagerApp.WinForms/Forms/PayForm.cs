﻿using OrderManagerApp.Domain.Models;
using OrderManagerApp.WinForms.Interfaces;

namespace OrderManagerApp.WinForms.Forms
{
    public partial class PayForm : Form, IViewPayForm
    {
        public Payment Payment { get; set; }
        public int ArrivalId { get; set; }
        public int OrderId { get; set; }

        public event IViewPayForm.PayFormOkButtonHandler onPayFormOkClick;

        public PayForm()
        {
            InitializeComponent();
        }

        private void payButton_Click(object sender, EventArgs e)
        { 
            Payment = new Payment();
            Payment.OrderId = OrderId;
            Payment.ArrivalId = ArrivalId;
            Payment.PaymentAmount = payNumBox.Value;
            onPayFormOkClick.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
