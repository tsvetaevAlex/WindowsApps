using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        public string Currency { get; set; }

        public event Action<int> AccountSelected;

        public AccountsGroup()
        {
            InitializeComponent();
        }

        private void AccountsGroup_Load(object sender, EventArgs e)
        {
            cmbAccounts.Items.Add(new AccountItem(1, "Cash"));
            cmbAccounts.Items.Add(new AccountItem(2, "Card"));
        }

        private void cmbAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccounts.SelectedItem is AccountItem acc)
                AccountSelected?.Invoke(acc.Id);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Add account ({Currency})");
        }

        private class AccountItem
        {
            public int Id { get; }
            public string Name { get; }

            public AccountItem(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public override string ToString() => Name;
        }
    }
}
