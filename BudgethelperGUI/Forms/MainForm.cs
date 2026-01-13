using System;
using System.Windows.Forms;
using BudgetHelper.Services;
using Budgethelper.Models;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        private SqlService _sql;

        public MainForm()
        {
            InitializeComponent();
            _sql = new SqlService("default-user");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUsdAccounts();
        }

        private void LoadUsdAccounts()
        {
            lvUsdAccounts.Items.Clear();

            using (var r = _sql.LoadAccounts("USD"))
            {
                while (r.Read())
                {
                    var item = new ListViewItem(r["Name"].ToString());
                    item.SubItems.Add(r["Balance"].ToString());
                    lvUsdAccounts.Items.Add(item);
                }
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            if (lvUsdAccounts.SelectedItems.Count == 0)
                return;

            string accountName = lvUsdAccounts.SelectedItems[0].Text;

            using (var f = new AddTransactionForm())
            {
                if (f.ShowDialog() != DialogResult.OK)
                    return;

                _sql.AddTransaction(
                    accountName,
                    f.Amount,
                    f.Type,
                    f.Description);

                LoadUsdAccounts();
            }
        }
    }
}
