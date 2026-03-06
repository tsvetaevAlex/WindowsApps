using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Budgethelper.Services;

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
                MessageBox.Show(
                    "Введите пароль",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string enteredPassword = HashPassword(txtPassword.Text);
            string storedHash = HashService.ComputePasswordHash(enteredPassword);

            if (storedHash == null || enteredPassword != storedHash)
            {
                MessageBox.Show(
                    "Неверный пароль",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }


        // Utils
        #region Utils
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar =
                chkShowPassword.Checked ? '\0' : '●';
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hashBytes =
                    sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                return Convert.ToBase64String(hashBytes);
            }
        }

        private void VeridyPassswod()
        {

        }

        #endregion
    }
}
