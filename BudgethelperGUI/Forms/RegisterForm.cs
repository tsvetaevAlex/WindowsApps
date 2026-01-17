using System;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class RegisterForm : Form
    {
        public string FirstName => txtFirstName.Text.Trim();
        public string Surname => txtSurname.Text.Trim();
        public string Patronymic => txtPatronymic.Text.Trim();
        public string Password => txtPassword.Text;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(Surname) ||
                string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Имя, фамилия и пароль обязательны");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}
