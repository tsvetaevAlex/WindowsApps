using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class AddTransactionForm
    {
        private NumericUpDown nudAmount;
        private RadioButton rbIncome;
        private RadioButton rbExpense;
        private TextBox txtDescription;
        private Button btnOk;
        private Button btnCancel;

        private void InitializeComponent()
        {
            nudAmount = new NumericUpDown();
            rbIncome = new RadioButton();
            rbExpense = new RadioButton();
            txtDescription = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();

            SuspendLayout();

            nudAmount.Location = new System.Drawing.Point(20, 20);
            nudAmount.Maximum = 1_000_000;

            rbIncome.Text = "Income";
            rbIncome.Location = new System.Drawing.Point(20, 60);
            rbIncome.Checked = true;

            rbExpense.Text = "Expense";
            rbExpense.Location = new System.Drawing.Point(120, 60);

            txtDescription.Location = new System.Drawing.Point(20, 100);
            txtDescription.Width = 240;

            btnOk.Text = "OK";
            btnOk.Location = new System.Drawing.Point(20, 140);
            btnOk.Click += btnOk_Click;

            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(120, 140);
            btnCancel.Click += btnCancel_Click;

            ClientSize = new System.Drawing.Size(280, 190);
            Controls.AddRange(new Control[]
            {
                nudAmount,
                rbIncome,
                rbExpense,
                txtDescription,
                btnOk,
                btnCancel
            });

            Text = "Add transaction";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
        }
    }
}
