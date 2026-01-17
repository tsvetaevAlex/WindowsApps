using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class AddTransactionForm
    {
        private TextBox txtAmount;
        private ComboBox cbType;
        private DateTimePicker dtpDate;
        private TextBox txtDescription;
        private Button btnAdd;
        private Label lblAmount;
        private Label lblType;
        private Label lblDate;
        private Label lblDescription;

        private void InitializeComponent()
        {
            txtAmount = new TextBox();
            cbType = new ComboBox();
            dtpDate = new DateTimePicker();
            txtDescription = new TextBox();
            btnAdd = new Button();
            lblAmount = new Label();
            lblType = new Label();
            lblDate = new Label();
            lblDescription = new Label();

            SuspendLayout();

            // Amount
            lblAmount.Text = "Amount";
            lblAmount.Left = 20;
            lblAmount.Top = 20;

            txtAmount.Left = 120;
            txtAmount.Top = 16;
            txtAmount.Width = 400;

            // Type
            lblType.Text = "Type";
            lblType.Left = 20;
            lblType.Top = 60;

            cbType.Left = 120;
            cbType.Top = 56;
            cbType.Width = 400;
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Date
            lblDate.Text = "Date";
            lblDate.Left = 20;
            lblDate.Top = 100;

            dtpDate.Left = 120;
            dtpDate.Top = 96;
            dtpDate.Width = 400;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";

            // Description
            lblDescription.Text = "Description";
            lblDescription.Left = 20;
            lblDescription.Top = 140;

            txtDescription.Left = 120;
            txtDescription.Top = 136;
            txtDescription.Width = 400;
            txtDescription.Height = 60;
            txtDescription.Multiline = true;

            // Button
            btnAdd.Text = "Add transaction";
            btnAdd.Left = 350;
            btnAdd.Top = 210;
            btnAdd.Width = 170;
            btnAdd.Click += btnAdd_Click;

            // Form
            ClientSize = new System.Drawing.Size(560, 270);
            Controls.AddRange(new Control[]
            {
                lblAmount, txtAmount,
                lblType, cbType,
                lblDate, dtpDate,
                lblDescription, txtDescription,
                btnAdd
            });

            Text = "Add transaction";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
        }
    }
}
