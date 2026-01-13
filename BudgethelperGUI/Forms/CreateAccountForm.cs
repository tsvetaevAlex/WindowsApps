using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Budgethelper.Forms
{
    public partial class CreateAccountForm : Form
    {
        public string AccountName => txtName.Text.Trim();
        public int InitialBalance => (int)nudBalance.Value;
        public string Currency { get; }

        public CreateAccountForm(string currency)
        {
            Currency = currency;
            InitializeComponent();
            lblCurrency.Text = currency;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AccountName))
            {
                MessageBox.Show("Введите название счёта");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
