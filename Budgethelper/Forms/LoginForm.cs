using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Budgethelper.Models;
using Budgethelper.Services;

namespace Budgethelper.Forms
{
    public partial class LoginForm : Form
    {
        private const Byte ReTryCount = 3;
        private Byte tryCount = 0;


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

            string storedHash = RegistryService.LoadUid();
            string newHash = HashService.GetHash(txtPassword.Text);

            if (newHash != storedHash)
            {
                Logger.SendMessage(Message_Type.Error, "Ошибка авторизации: Введен Неверный пароль.");
                Logger.SendMessage(Message_Type.Hint, "попробуцйте еще раз.");

                MessageBox.Show(
                    "Неверный пароль",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            if (tryCount <= ReTryCount)
            {
                DialogResult = DialogResult.OK;
                Close();

                LoginForm auth = new LoginForm();
                auth.ShowDialog();
            }
            else {
                Logger.SendMessage(Message_Type.Error,"Вы ввели неверныый пароль 3 раза.\r\n" +
                    "пардон в целях бнзопасноти и сохранения целостности и приватности данных\r\n" +
                    "я вынужден прекратить текущую рабочую сессию.Попробуйте позже еще раз.");

                MessageBox.Show(
                    "Неверный пароль",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Application.Exit();
            }

        }


        // Utils
        #region Utils
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar =
                chkShowPassword.Checked ? '\0' : '●';
        }

        #endregion
    }
}
