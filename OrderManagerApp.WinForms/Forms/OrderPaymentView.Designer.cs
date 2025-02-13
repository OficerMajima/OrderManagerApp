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
            exitButton = new Button();
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
            panel1.Controls.Add(exitButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 54);
            panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = SystemColors.AppWorkspace;
            exitButton.Location = new Point(1033, 3);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(57, 49);
            exitButton.TabIndex = 0;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // orderDataGrid
            // 
            orderDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDataGrid.Location = new Point(375, 89);
            orderDataGrid.Margin = new Padding(9, 8, 9, 8);
            orderDataGrid.Name = "orderDataGrid";
            orderDataGrid.RowHeadersWidth = 51;
            orderDataGrid.ScrollBars = ScrollBars.Vertical;
            orderDataGrid.Size = new Size(340, 520);
            orderDataGrid.TabIndex = 0;
            // 
            // arrivalDataGrid
            // 
            arrivalDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            arrivalDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            arrivalDataGrid.Location = new Point(17, 89);
            arrivalDataGrid.Margin = new Padding(9, 8, 9, 8);
            arrivalDataGrid.Name = "arrivalDataGrid";
            arrivalDataGrid.RowHeadersWidth = 51;
            arrivalDataGrid.ScrollBars = ScrollBars.Vertical;
            arrivalDataGrid.Size = new Size(340, 600);
            arrivalDataGrid.TabIndex = 1;
            // 
            // paymentsDataGrid
            // 
            paymentsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentsDataGrid.Location = new Point(733, 89);
            paymentsDataGrid.Margin = new Padding(9, 8, 9, 8);
            paymentsDataGrid.Name = "paymentsDataGrid";
            paymentsDataGrid.RowHeadersWidth = 51;
            paymentsDataGrid.ScrollBars = ScrollBars.Vertical;
            paymentsDataGrid.Size = new Size(340, 600);
            paymentsDataGrid.TabIndex = 2;
            // 
            // payButton
            // 
            payButton.FlatAppearance.BorderSize = 0;
            payButton.FlatStyle = FlatStyle.Flat;
            payButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            payButton.Location = new Point(375, 619);
            payButton.Margin = new Padding(3, 2, 3, 2);
            payButton.Name = "payButton";
            payButton.Size = new Size(340, 70);
            payButton.TabIndex = 4;
            payButton.Text = "Оплатить";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(17, 56);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 5;
            label1.Text = "Ваши приходы:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(375, 56);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 6;
            label2.Text = "Ваши заказы:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(733, 56);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 7;
            label3.Text = "Ваши платежи:";
            // 
            // OrderPaymentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 704);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(payButton);
            Controls.Add(paymentsDataGrid);
            Controls.Add(arrivalDataGrid);
            Controls.Add(orderDataGrid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private Button exitButton;
        private Button payButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}