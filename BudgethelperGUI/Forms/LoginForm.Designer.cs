using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.chkShowPassword = new CheckBox();
            this.btnLogin = new Button();
            this.btnCancel = new Button();

            this.SuspendLayout();

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 20);
            this.lblPassword.Text = "Пароль:";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(28, 40);
            this.txtPassword.Width = 240;
            this.txtPassword.PasswordChar = '●';

            // chkShowPassword
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(28, 70);
            this.chkShowPassword.Text = "Показать пароль";
            this.chkShowPassword.CheckedChanged +=
                new System.EventHandler(this.chkShowPassword_CheckedChanged);

            // btnLogin
            this.btnLogin.Text = "Войти";
            this.btnLogin.Location = new System.Drawing.Point(28, 105);
            this.btnLogin.Width = 100;
            this.btnLogin.Click +=
                new System.EventHandler(this.btnLogin_Click);

            // btnCancel
            this.btnCancel.Text = "Выход";
            this.btnCancel.Location = new System.Drawing.Point(168, 105);
            this.btnCancel.Width = 100;
            this.btnCancel.Click +=
                new System.EventHandler(this.btnCancel_Click);

            // LoginForm
            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Авторизация";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
