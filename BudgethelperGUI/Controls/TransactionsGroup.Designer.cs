using System.Windows.Forms;

namespace Budgethelper.Controls
{
    partial class TransactionsGroup
    {
        private TextBox txtAmount;
        private ComboBox cmbType;
        private TextBox txtDescription;
        private DateTimePicker dtpDate;
        private Button btnAdd;

        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            cmbType = new ComboBox();
            txtDescription = new TextBox();
            dtpDate = new DateTimePicker();
            btnAdd = new Button();

            cmbType.Items.AddRange(new object[]
            {
                Budgethelper.Models.TransactionType.Income,
                Budgethelper.Models.TransactionType.Expense
            });
            cmbType.SelectedIndex = 0;

            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.Controls.AddRange(new Control[]
            {
                txtAmount, cmbType, txtDescription, dtpDate, btnAdd
            });

            this.Controls.Add(panel);
            this.Height = 45;
        }
    }
}
