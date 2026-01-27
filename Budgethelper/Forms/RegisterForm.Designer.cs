using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class RegisterForm
    {
        private Button btnRegister;
        private TextBox txtName;

        private void InitializeComponent()
        {
            btnRegister = new Button();
            txtName = new TextBox();

            // txtName
            txtName.Location = new Point(20, 20);
            txtName.Size = new Size(200, 23);

            // btnRegister
            btnRegister.Location = new Point(20, 60);
            btnRegister.Size = new Size(200, 30);
            btnRegister.Text = "Register";
            btnRegister.Click += btnRegister_Click;

            // Form
            ClientSize = new Size(250, 120);
            Controls.Add(txtName);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            MaximizeBox = false;
        }
    }
}
