using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        public string Currency { get; set; }

        public TransactionsGroup()
        {
            InitializeComponent();
            SetDisabledState();
        }

        public void SetDisabledState()
        {
            Enabled = false;
            lblHint.Visible = true;
        }

        public void EnableForAccount(int accountId)
        {
            Enabled = true;
            lblHint.Visible = false;

            listBox.Items.Clear();
            listBox.Items.Add($"Transaction for account {accountId}");
        }
    }
}
