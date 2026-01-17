using System;
using System.Drawing;
using System.Windows.Forms;
using BudgetHelper.Services;
using Budgethelper.Controls;
using Budgethelper.Models;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        private SqlService _sql;

        public MainForm()
        {
            InitializeComponent();

            _sql = new SqlService("user1");

            accountsGroup.Bind(_sql);
            transactionsGroup.Bind(_sql, () => accountsGroup.SelectedAccountId);

            accountsGroup.AccountChanged += id =>
            {
                transactionsGroup.EnableForAccount(!string.IsNullOrEmpty(id));
                LoadTransactions();
            };

            transactionsGroup.TransactionAdded += () =>
            {
                accountsGroup.Reload();
                LoadTransactions();
            };
        }

        private void LoadTransactions()
        {
            dgv.Rows.Clear();

            foreach (var tx in _sql.LoadTransactions(
                accountsGroup.SelectedAccountId,
                dtFrom.Value,
                dtTo.Value,
                cmbType.SelectedIndex == 0 ? null : (TransactionType?)cmbType.SelectedItem))
            {
                int r = dgv.Rows.Add(tx.Date, tx.Type, tx.Amount, tx.Description);
                dgv.Rows[r].DefaultCellStyle.ForeColor =
                    tx.Type == TransactionType.Income ? Color.DarkGreen : Color.DarkRed;
            }
        }
    }
}
