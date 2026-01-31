using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSurename.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Все поля обязательны для заполнения!");
                return;
            }

            var user = new Account
            {
                Uid = Guid.NewGuid().ToString(),
                Name = txtName.Text.Trim(),
                SureName = txtSurename.Text.Trim(),
                LastName = txtLastname.Text.Trim(),
                PasswordHash = txtPassword.Text
            };

            RegistryService.SaveUser(user); // сохраняем пользователя

            Session.Uid = user.Uid; // сразу сохраняем в сессию

            MessageBox.Show("Пользователь успешно зарегистрирован!");

            // После регистрации открываем MainForm
            MainForm mainForm = new MainForm();
            mainForm.Show();

            this.Hide(); // скрываем RegisterForm
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }
    }
}
