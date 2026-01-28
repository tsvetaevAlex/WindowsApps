using System;
using System.Windows.Forms;
using Budgethelper.Services;
using Budgethelper.Models;

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
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            string uid = RegistryService.LoadUid();
            if (uid == null)
            {
                MessageBox.Show("Пользователь не зарегистрирован");
                return;
            }

            string hash = HashService.GetMd5(txtPassword.Text);

            Session.Uid = uid;
            Session.CurrentUser = SqlService.LoadUser();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }
    }
}
