using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class CreateAccountForm
    {
        private TextBox txtName;
        private TextBox txtBalance;
        private Label lblName;
        private Label lblBalance;
        private Label lblCurrency;
        private Button btnCreate;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtBalance = new TextBox();
            lblName = new Label();
            lblBalance = new Label();
            lblCurrency = new Label();
            btnCreate = new Button();

            SuspendLayout();

            lblCurrency.Left = 20;
            lblCurrency.Top = 15;
            lblCurrency.Width = 300;

            lblName.Text = "Account name";
            lblName.Left = 20;
            lblName.Top = 50;

            txtName.Left = 140;
            txtName.Top = 46;
            txtName.Width = 260;

            lblBalance.Text = "Initial balance";
            lblBalance.Left = 20;
            lblBalance.Top = 90;

            txtBalance.Left = 140;
            txtBalance.Top = 86;
            txtBalance.Width = 260;

            btnCreate.Text = "Create";
            btnCreate.Left = 280;
            btnCreate.Top = 130;
            btnCreate.Width = 120;
            btnCreate.Click += btnCreate_Click;

            ClientSize = new System.Drawing.Size(430, 180);
            Controls.AddRange(new Control[]
            {
                lblCurrency,
                lblName, txtName,
                lblBalance, txtBalance,
                btnCreate
            });

            Text = "Create account";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;

            ResumeLayout(false);
        }
    }
}
