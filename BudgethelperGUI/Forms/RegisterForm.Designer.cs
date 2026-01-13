using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class RegisterForm
    {
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnRegister;

        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnRegister = new Button();

            SuspendLayout();

            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Location = new System.Drawing.Point(30, 30);

            chkShowPassword.Text = "Show password";
            chkShowPassword.Location = new System.Drawing.Point(30, 60);
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            btnRegister.Text = "Register";
            btnRegister.Location = new System.Drawing.Point(30, 100);
            btnRegister.Click += btnRegister_Click;

            ClientSize = new System.Drawing.Size(300, 160);
            Controls.AddRange(new Control[]
            {
                txtPassword,
                chkShowPassword,
                btnRegister
            });

            Text = "Register";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
        }
    }
}
