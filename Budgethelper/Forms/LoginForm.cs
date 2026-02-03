using System;
using System.Windows.Forms;
using Budgethelper.Models;
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
            var user = SqlService.LoadUserByUid(Session.Uid);

            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            if (!HashService.Verify(tbPassword.Text, user.PasswordHash))
            {
                MessageBox.Show("Неверный пароль");
                return;
            }

            Session.Uid = user.Uid;
            Session.CurrentUser = user;
            Session.IsAuthorized = true;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
