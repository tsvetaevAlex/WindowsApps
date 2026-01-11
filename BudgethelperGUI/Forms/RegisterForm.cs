using System;
using System.Linq;
using System.Windows.Forms;

namespace Budgethelper
{
    public partial class RegisterForm : Form
    {
        // Свойства для доступа к данным
        public string FirstName => txtFirstName.Text.Trim();
        public string LastName => txtLastName.Text.Trim();
        public string Password => txtPassword.Text;

        public RegisterForm()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += (s, e) => this.Close();

            chkShowPassword.CheckedChanged += (s, e) =>
            {
                bool show = chkShowPassword.Checked;
                txtPassword.PasswordChar = show ? '\0' : '●';
                txtConfirmPassword.PasswordChar = show ? '\0' : '●';
            };
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.Text == "First Name" ||
                string.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text == "Last Name" ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("Пароль должен быть минимум 6 символов, содержать хотя бы одну букву и одну цифру",
                    "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 6 &&
                   password.Any(char.IsDigit) &&
                   password.Any(char.IsLetter);
        }
    }
}
