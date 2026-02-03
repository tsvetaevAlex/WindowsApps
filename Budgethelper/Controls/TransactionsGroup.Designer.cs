namespace Budgethelper.Controls
{
    partial class TransactionsGroup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.RichTextBox rtb_transactions_QTY;
        private System.Windows.Forms.Label label_transaction_QTY;
        private System.Windows.Forms.RichTextBox rtb_SessionStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.rtb_transactions_QTY = new System.Windows.Forms.RichTextBox();
            this.label_transaction_QTY = new System.Windows.Forms.Label();
            this.rtb_SessionStats = new System.Windows.Forms.RichTextBox();

            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();

            // txtAccountName
            this.txtAccountName.Location = new System.Drawing.Point(10, 10);
            this.txtAccountName.Size = new System.Drawing.Size(140, 23);
            this.txtAccountName.ReadOnly = true;

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(160, 10);
            this.txtAmount.Size = new System.Drawing.Size(90, 23);

            // datePicker
            this.datePicker.Location = new System.Drawing.Point(260, 10);
            this.datePicker.Size = new System.Drawing.Size(140, 23);

            // comboType
            this.comboType.Location = new System.Drawing.Point(410, 10);
            this.comboType.Size = new System.Drawing.Size(100, 23);

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(520, 10);
            this.txtDescription.Size = new System.Drawing.Size(140, 23);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(670, 10);
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnYesterday
            this.btnYesterday.Location = new System.Drawing.Point(260, 40);
            this.btnYesterday.Size = new System.Drawing.Size(70, 23);
            this.btnYesterday.Text = "Вчера";
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);

            // btnToday
            this.btnToday.Location = new System.Drawing.Point(340, 40);
            this.btnToday.Size = new System.Drawing.Size(70, 23);
            this.btnToday.Text = "Сегодня";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);

            // grid
            this.grid.Location = new System.Drawing.Point(10, 75);
            this.grid.Size = new System.Drawing.Size(750, 260);
            this.grid.ReadOnly = true;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.grid.Columns.Add("Account", "Счет");
            this.grid.Columns.Add("Date", "Дата");
            this.grid.Columns.Add("Amount", "Сумма");
            this.grid.Columns.Add("Type", "Тип");
            this.grid.Columns.Add("Description", "Описание");

            // rtb_transactions_QTY
            this.rtb_transactions_QTY.BackColor = System.Drawing.Color.SteelBlue;
            this.rtb_transactions_QTY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtb_transactions_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.rtb_transactions_QTY.Location = new System.Drawing.Point(410, 63);
            this.rtb_transactions_QTY.Size = new System.Drawing.Size(131, 46);
            this.rtb_transactions_QTY.Multiline = false;
            this.rtb_transactions_QTY.WordWrap = false;
            this.rtb_transactions_QTY.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;

            // label
            this.label_transaction_QTY.AutoSize = true;
            this.label_transaction_QTY.Location = new System.Drawing.Point(406, 45);
            this.label_transaction_QTY.Text = "транзакций за сессию";

            // rtb_SessionStats
            this.rtb_SessionStats.BackColor = System.Drawing.Color.Black;
            this.rtb_SessionStats.ForeColor = System.Drawing.Color.White;
            this.rtb_SessionStats.Location = new System.Drawing.Point(547, 45);
            this.rtb_SessionStats.Size = new System.Drawing.Size(213, 64);

            // add controls
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.rtb_transactions_QTY);
            this.Controls.Add(this.label_transaction_QTY);
            this.Controls.Add(this.rtb_SessionStats);

            this.Name = "TransactionsGroup";
            this.Size = new System.Drawing.Size(780, 400);

            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
