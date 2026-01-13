using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class CreateAccountForm
    {
        private Label lblName;
        private Label lblBalance;
        private Label lblCurrency;
        private TextBox txtName;
        private NumericUpDown nudBalance;
        private Button btnOk;
        private Button btnCancel;

        private void InitializeComponent()
        {
            lblName = new Label();
            lblBalance = new Label();
            lblCurrency = new Label();
            txtName = new TextBox();
            nudBalance = new NumericUpDown();
            btnOk = new Button();
            btnCancel = new Button();

            SuspendLayout();

            lblName.Text = "Название счёта:";
            lblName.Location = new System.Drawing.Point(20, 20);

            txtName.Location = new System.Drawing.Point(150, 20);
            txtName.Width = 200;

            lblBalance.Text = "Начальный баланс:";
            lblBalance.Location = new System.Drawing.Point(20, 60);

            nudBalance.Location = new System.Drawing.Point(150, 60);
            nudBalance.Maximum = 1_000_000;

            lblCurrency.Location = new System.Drawing.Point(150, 95);
            lblCurrency.AutoSize = true;

            btnOk.Text = "Создать";
            btnOk.Location = new System.Drawing.Point(150, 130);
            btnOk.Click += btnOk_Click;

            btnCancel.Text = "Отмена";
            btnCancel.Location = new System.Drawing.Point(260, 130);
            btnCancel.Click += btnCancel_Click;

            ClientSize = new System.Drawing.Size(380, 180);
            Controls.AddRange(new Control[]
            {
                lblName, txtName,
                lblBalance, nudBalance,
                lblCurrency,
                btnOk, btnCancel
            });

            Text = "Создание счёта";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
        }
    }
}
