using System.Windows.Forms;
using Budgethelper.Controls;

namespace Budgethelper.Forms
{
    partial class MainForm
    {
        private AccountsGroup accountsGroup;
        private TransactionsGroup transactionsGroup;
        private DataGridView dgv;
        private DateTimePicker dtFrom, dtTo;
        private ComboBox cmbType;

        private void InitializeComponent()
        {
            this.Text = "BudgetHelper";
            this.Width = 900;
            this.Height = 600;

            accountsGroup = new AccountsGroup { Dock = DockStyle.Top };
            transactionsGroup = new TransactionsGroup { Dock = DockStyle.Top };

            GroupBox gbAccounts = new GroupBox
            {
                Text = "Выбор аккаунта",
                Dock = DockStyle.Top,
                Height = 70
            };
            gbAccounts.Controls.Add(accountsGroup);

            GroupBox gbAdd = new GroupBox
            {
                Text = "Добавление транзакции",
                Dock = DockStyle.Top,
                Height = 80
            };
            gbAdd.Controls.Add(transactionsGroup);

            dgv = new DataGridView { Dock = DockStyle.Fill };
            dgv.Columns.Add("Date", "Date");
            dgv.Columns.Add("Type", "Type");
            dgv.Columns.Add("Amount", "Amount");
            dgv.Columns.Add("Desc", "Comment");

            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            cmbType = new ComboBox();
            cmbType.Items.AddRange(new object[] { "All", Models.TransactionType.Income, Models.TransactionType.Expense });
            cmbType.SelectedIndex = 0;

            this.Controls.Add(dgv);
            this.Controls.Add(gbAdd);
            this.Controls.Add(gbAccounts);
        }
    }
}
