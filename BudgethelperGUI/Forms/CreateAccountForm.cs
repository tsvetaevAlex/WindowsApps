using System;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class CreateAccountForm : Form
    {
        public string AccountName { get; private set; }
        public int InitialBalance { get; private set; }

        public CreateAccountForm(string currency)
        {
            InitializeComponent();
            lblCurrency.Text = $"Currency: {currency}";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Account name required");
                return;
            }

            if (!int.TryParse(txtBalance.Text, out int balance))
            {
                MessageBox.Show("Invalid balance");
                return;
            }

            AccountName = txtName.Text.Trim();
            InitialBalance = balance;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
