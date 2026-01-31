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

            comboType.DataSource =
                Enum.GetValues(typeof(TransactionType));

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
            Enabled = true;

            var list =
                TransactionsService.GetByAccount(accountName);

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

                if (t.OperationType == TransactionType.Income)
                    row.DefaultCellStyle.BackColor =
                        Color.FromArgb(220, 245, 220);
                else
                    row.DefaultCellStyle.BackColor =
                        Color.FromArgb(255, 228, 228);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_currentAccount))
                return;

            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount))
                return;

            var transaction = new Transaction
            {
                AccountName = _currentAccount,
                Amount = amount,
                OperationType =
                    (TransactionType)comboType.SelectedItem,
                Date = datePicker.Value,
                Description = txtDescription.Text
            };

            transaction =
                TransactionsService.Add(transaction);

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
    }
}
