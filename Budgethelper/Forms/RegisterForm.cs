using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Budgethelper.Forms
{
    public partial class RegisterForm : Form // <-- наследуемся от Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSureName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var account = new Account
            {
                Name = txtName.Text.Trim(),
                SureName = txtSureName.Text.Trim(),
                LastName = txtLastName.Text.Trim()
            };

            string passwordHash = HashService.GetMd5(txtPassword.Text);

            // Инициализируем сессию
            HashService.InitSessionUid(account);

            // Сохраняем пользователя в БД
            SqlService.SaveUser(account, passwordHash);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }
    }
}
