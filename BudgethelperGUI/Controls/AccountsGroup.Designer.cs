using System.Windows.Forms;

namespace Budgethelper.Controls
{
    partial class AccountsGroup
    {
        private ComboBox cmbAccounts;

        private void InitializeComponent()
        {
            this.cmbAccounts = new ComboBox();
            this.SuspendLayout();

            cmbAccounts.Dock = DockStyle.Fill;
            cmbAccounts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccounts.SelectedIndexChanged += cmbAccounts_SelectedIndexChanged;

            this.Controls.Add(cmbAccounts);
            this.Height = 40;
            this.ResumeLayout(false);
        }
    }
}
