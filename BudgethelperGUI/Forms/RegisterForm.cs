using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public class RegisterForm : Form
    {
        private TextBox txtFirstName;
        private TextBox txtSureName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private Button btnRegister;

        private static readonly Regex NameRegex =
            new Regex("^[a-zA-Zа-яА-Я]+$");

        public RegisterForm()
        {
            Text = "Регистрация";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Width = 320;
            Height = 260;

            InitializeControls();
        }

        private void InitializeControls()
        {
            Label lblFirst = new Label { Text = "Имя *", Left = 10, Top = 20 };
            Label lblSure = new Label { Text = "Фамилия *", Left = 10, Top = 60 };
            Label lblLast = new Label { Text = "Отчество", Left = 10, Top = 100 };
            Label lblPass = new Label { Text = "Пароль *", Left = 10, Top = 140 };

            txtFirstName = new TextBox { Left = 120, Top = 20, Width = 160 };
            txtSureName = new TextBox { Left = 120, Top = 60, Width = 160 };
            txtLastName = new TextBox { Left = 120, Top = 100, Width = 160 };
            txtPassword = new TextBox { Left = 120, Top = 140, Width = 160, PasswordChar = '*' };

            btnRegister = new Button
            {
                Text = "Зарегистрироваться",
                Left = 70,
                Top = 180,
                Width = 170
            };
            btnRegister.Click += BtnRegister_Click;

            Controls.AddRange(new Control[]
            {
                lblFirst, lblSure, lblLast, lblPass,
                txtFirstName, txtSureName, txtLastName, txtPassword,
                btnRegister
            });
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateInput()
        {
            if (!NameRegex.IsMatch(txtFirstName.Text))
                return ShowError("Имя обязательно и должно содержать только буквы");

            if (!NameRegex.IsMatch(txtSureName.Text))
                return ShowError("Фамилия обязательна и должна содержать только буквы");

            if (!string.IsNullOrWhiteSpace(txtLastName.Text) &&
                !NameRegex.IsMatch(txtLastName.Text))
                return ShowError("Отчество должно содержать только буквы");

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
                return ShowError("Пароль обязателен");

            return true;
        }

        private bool ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
