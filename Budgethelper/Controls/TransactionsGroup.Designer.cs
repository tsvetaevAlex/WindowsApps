namespace Budgethelper.Controls
{
    partial class TransactionsGroup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.DataGridView grid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();

            txtAmount.Location = new System.Drawing.Point(10, 10);
            txtAmount.Size = new System.Drawing.Size(100, 23);

            datePicker.Location = new System.Drawing.Point(120, 10);
            datePicker.Size = new System.Drawing.Size(150, 23);

            comboType.Location = new System.Drawing.Point(280, 10);
            comboType.Size = new System.Drawing.Size(100, 23);

            txtDescription.Location = new System.Drawing.Point(390, 10);
            txtDescription.Size = new System.Drawing.Size(150, 23);

            btnAdd.Location = new System.Drawing.Point(550, 10);
            btnAdd.Size = new System.Drawing.Size(80, 23);
            btnAdd.Text = "Добавить";
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            btnYesterday.Location = new System.Drawing.Point(120, 40);
            btnYesterday.Size = new System.Drawing.Size(70, 23);
            btnYesterday.Text = "Вчера";
            btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);

            btnToday.Location = new System.Drawing.Point(200, 40);
            btnToday.Size = new System.Drawing.Size(70, 23);
            btnToday.Text = "Сегодня";
            btnToday.Click += new System.EventHandler(this.btnToday_Click);

            grid.Location = new System.Drawing.Point(10, 75);
            grid.Size = new System.Drawing.Size(620, 300);
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            grid.Columns.Add("Account", "Счет");
            grid.Columns.Add("Date", "Дата");
            grid.Columns.Add("Amount", "Сумма");
            grid.Columns.Add("Type", "Тип");
            grid.Columns.Add("Description", "Описание");

            this.Controls.Add(txtAmount);
            this.Controls.Add(datePicker);
            this.Controls.Add(comboType);
            this.Controls.Add(txtDescription);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnYesterday);
            this.Controls.Add(btnToday);
            this.Controls.Add(grid);

            this.Size = new System.Drawing.Size(650, 400);

            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
