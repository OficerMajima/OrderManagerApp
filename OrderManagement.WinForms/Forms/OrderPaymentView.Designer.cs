namespace OrderManagerApp.WinForms.Forms
{
    partial class OrderPaymentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            orderDataGrid = new DataGridView();
            arrivalDataGrid = new DataGridView();
            paymentsDataGrid = new DataGridView();
            payButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrivalDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1469, 93);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = SystemColors.AppWorkspace;
            button3.Location = new Point(1385, 12);
            button3.Name = "button3";
            button3.Size = new Size(65, 65);
            button3.TabIndex = 0;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // orderDataGrid
            // 
            orderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGrid.Location = new Point(477, 127);
            orderDataGrid.Margin = new Padding(10);
            orderDataGrid.Name = "orderDataGrid";
            orderDataGrid.RowHeadersWidth = 51;
            orderDataGrid.Size = new Size(399, 687);
            orderDataGrid.TabIndex = 0;
            // 
            // arrivalDataGrid
            // 
            arrivalDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            arrivalDataGrid.Location = new Point(19, 127);
            arrivalDataGrid.Margin = new Padding(10);
            arrivalDataGrid.Name = "arrivalDataGrid";
            arrivalDataGrid.RowHeadersWidth = 51;
            arrivalDataGrid.Size = new Size(363, 687);
            arrivalDataGrid.TabIndex = 1;
            // 
            // paymentsDataGrid
            // 
            paymentsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsDataGrid.Location = new Point(896, 127);
            paymentsDataGrid.Margin = new Padding(10);
            paymentsDataGrid.Name = "paymentsDataGrid";
            paymentsDataGrid.RowHeadersWidth = 51;
            paymentsDataGrid.Size = new Size(554, 793);
            paymentsDataGrid.TabIndex = 2;
            // 
            // payButton
            // 
            payButton.FlatAppearance.BorderSize = 0;
            payButton.FlatStyle = FlatStyle.Flat;
            payButton.Location = new Point(526, 827);
            payButton.Name = "payButton";
            payButton.Size = new Size(350, 93);
            payButton.TabIndex = 4;
            payButton.Text = "Оплатить";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(19, 96);
            label1.Name = "label1";
            label1.Size = new Size(183, 31);
            label1.TabIndex = 5;
            label1.Text = "Ваши приходы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(526, 96);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 6;
            label2.Text = "Ваши заказы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(896, 96);
            label3.Name = "label3";
            label3.Size = new Size(178, 31);
            label3.TabIndex = 7;
            label3.Text = "Ваши платежи:";
            // 
            // OrderPaymentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 939);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(payButton);
            Controls.Add(paymentsDataGrid);
            Controls.Add(arrivalDataGrid);
            Controls.Add(orderDataGrid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderPaymentView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrivalDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView orderDataGrid;
        private DataGridView arrivalDataGrid;
        private DataGridView paymentsDataGrid;
        private Button button3;
        private Button payButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}