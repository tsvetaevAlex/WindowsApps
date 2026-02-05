using Budgethelper.Models;
using Budgethelper.Services;
using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

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
                string.IsNullOrWhiteSpace(txtSureName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            string uid = Guid.NewGuid().ToString();
            string passwordHash = ComputeHash(txtPassword.Text);

            Session.Uid = uid;
            Session.DbPath = $"{uid}.sqlite";

            var user = new User
            {
                Uid = uid,
                Name = txtName.Text.Trim(),
                SureName = txtSureName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                PasswordHash = passwordHash
            };

            SqlService.CreateUser(user);

            Session.CurrentUser = user;
            Session.IsAuthorized = true;

            var key = Registry.CurrentUser.CreateSubKey(Session.RegistryKeyPath);
            key.SetValue("Uid", uid);

            MessageBox.Show("Регистрация завершена");

            Hide();
            new MainForm().Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private string ComputeHash(string input)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(input);
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
