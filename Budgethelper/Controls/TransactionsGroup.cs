using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Budgethelper.Models;
using Budgethelper.Services;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        private string _currentAccount;

        public TransactionsGroup()
        {
            InitializeComponent();

            comboType.DataSource = Enum.GetValues(typeof(TransactionType));

            SetInactive();
        }

        public void SetInactive()
        {
            Enabled = false;
            grid.Rows.Clear();
        }

        public void LoadAccount(string accountName)
        {
            _currentAccount = accountName;
            txtAccountName.Text = accountName;
            Enabled = true;

            var list = TransactionsService.GetByAccount(accountName);
            FillGrid(list);
        }

        private void FillGrid(List<Transaction> list)
        {
            grid.Rows.Clear();

            foreach (var t in list)
            {
                int rowIndex = grid.Rows.Add(
                    t.AccountName,
                    t.Date.ToShortDateString(),
                    t.Amount,
                    t.OperationType,
                    t.Description
                );

                var row = grid.Rows[rowIndex];

                row.DefaultCellStyle.BackColor =
                    t.OperationType == TransactionType.Income ?
                    Color.FromArgb(220, 245, 220) :
                    Color.FromArgb(255, 228, 228);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_currentAccount))
                return;

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
                return;

            var transaction = new Transaction
            {
                AccountName = _currentAccount,
                Amount = amount,
                OperationType = (TransactionType)comboType.SelectedItem,
                Date = datePicker.Value,
                Description = txtDescription.Text
            };

            transaction = TransactionsService.Add(transaction);

            // Обновляем счетчики сессии
            Session.TransactionQTY++;
            if (transaction.OperationType == TransactionType.Income)
                Session.TotalIncomeAmount += transaction.Amount;
            else
                Session.TotalExpenseAmount += transaction.Amount;

            UpdateSessionStats();

            LoadAccount(_currentAccount);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Today;
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            datePicker.Value = DateTime.Today.AddDays(-1);
        }

        private void UpdateSessionStats()
        {
            rtb_transactions_QTY.Text = Session.TransactionQTY.ToString();

            rtb_SessionStats.Clear();

            rtb_SessionStats.SelectionColor = Color.White;
            rtb_SessionStats.AppendText(
                $"Всего транзакций: {Session.TransactionQTY} на сумму {Session.TotalIncomeAmount - Session.TotalExpenseAmount}\n"
            );

            rtb_SessionStats.SelectionColor = Color.Lime;
            rtb_SessionStats.AppendText(
                $"Транзакции поступления: {Session.TotalIncomeAmount}\n"
            );

            rtb_SessionStats.SelectionColor = Color.Red;
            rtb_SessionStats.AppendText(
                $"Транзакции расхода: {Session.TotalExpenseAmount}\n"
            );
        }
    }
}
