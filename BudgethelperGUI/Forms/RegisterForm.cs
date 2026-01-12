using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class RegisterForm : Form
    {
        public string NameValue => txtName.Text.Trim();
        public string SurnameValue => txtSurname.Text.Trim();
        public string LastNameValue => txtLastName.Text.Trim();
        public string PasswordValue => txtPassword.Text;

        private Color defaultBackColor;

        public RegisterForm()
        {
            InitializeComponent();
            WireEvents();
            defaultBackColor = txtName.BackColor;
        }

        private void WireEvents()
        {
            btnRegister.Click += BtnRegister_Click;
            btnCancel.Click += (s, e) => Close();

            chkShowPassword.CheckedChanged += (s, e) =>
            {
                bool show = chkShowPassword.Checked;
                txtPassword.PasswordChar = show ? '\0' : '●';
                txtConfirmPassword.PasswordChar = show ? '\0' : '●';
            };

            txtName.GotFocus += RemovePlaceholder;
            txtName.LostFocus += AddPlaceholder;

            txtSurname.GotFocus += RemovePlaceholder;
            txtSurname.LostFocus += AddPlaceholder;

            txtLastName.GotFocus += RemovePlaceholder;
            txtLastName.LostFocus += AddPlaceholder;

            txtPassword.GotFocus += RemovePlaceholderPassword;
            txtPassword.LostFocus += AddPlaceholderPassword;

            txtConfirmPassword.GotFocus += RemovePlaceholderPassword;
            txtConfirmPassword.LostFocus += AddPlaceholderPassword;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            bool valid = true;

            // Reset colors
            ResetFieldColor(txtName);
            ResetFieldColor(txtSurname);

            // Required fields
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text == "Enter name")
            {
                MarkInvalid(txtName);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text) || txtSurname.Text == "Enter surname")
            {
                MarkInvalid(txtSurname);
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password validation
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsPasswordValid(txtPassword.Text))
            {
                MessageBox.Show("Password must be at least 6 characters and contain letters and digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void MarkInvalid(TextBox tb)
        {
            tb.BackColor = Color.MistyRose;
            toolTip.SetToolTip(tb, "Required field");
        }

        private void ResetFieldColor(TextBox tb)
        {
            tb.BackColor = defaultBackColor;
            toolTip.SetToolTip(tb, null);
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if ((tb == txtName && tb.Text == "Enter name") ||
                (tb == txtSurname && tb.Text == "Enter surname") ||
                (tb == txtLastName && tb.Text == "Enter last name (optional)"))
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == txtName) tb.Text = "Enter name";
                if (tb == txtSurname) tb.Text = "Enter surname";
                if (tb == txtLastName) tb.Text = "Enter last name (optional)";
                tb.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholderPassword(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.ForeColor = Color.Black;
        }

        private void AddPlaceholderPassword(object sender, EventArgs e)
        {
            // Optional: можно сделать подсказку через CueBanner API, но проще оставить пустым
        }

        private bool IsPasswordValid(string password)
        {
            return password.Length >= 6 &&
                   password.Any(char.IsLetter) &&
                   password.Any(char.IsDigit);
        }
    }
}
