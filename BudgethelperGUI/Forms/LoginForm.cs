using Budgethelper.Services;
using BudgetHelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string passwordHash = HashService.GetMd5(txtPassword.Text);

            if (!RegistryService.ValidatePassword(passwordHash))
            {
                MessageBox.Show(
                    "Неверный пароль",
                    "Авторизация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Logger.SendMessage("User logged in");
            DialogResult = DialogResult.OK;
            Close();
        }

        // ✅ ДОБАВЛЕНО
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Logger.SendMessage("Login cancelled");
            Application.Exit();
        }

        // ✅ ДОБАВЛЕНО
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
