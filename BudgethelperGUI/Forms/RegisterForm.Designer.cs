using System;
using System.Windows.Forms;
using BudgethelperGUI;
using BudgethelperGUI.Services;
using BudgethelperGUI.Forms;

namespace BudgethelperGUI
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnCancel;
        private CheckBox chkShowPassword;

        private void InitializeComponent()
        {
            this.txtFirstName = new TextBox();
            this.txtLastName = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            this.btnRegister = new Button();
            this.btnCancel = new Button();
            this.chkShowPassword = new CheckBox();

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(20, 20);
            this.txtFirstName.Width = 200;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.GotFocus += RemovePlaceholder;
            this.txtFirstName.LostFocus += AddPlaceholder;

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(20, 50);
            this.txtLastName.Width = 200;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.GotFocus += RemovePlaceholder;
            this.txtLastName.LostFocus += AddPlaceholder;

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(20, 80);
            this.txtPassword.Width = 200;
            this.txtPassword.PasswordChar = '●';

            // txtConfirmPassword
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 110);
            this.txtConfirmPassword.Width = 200;
            this.txtConfirmPassword.PasswordChar = '●';

            // btnRegister
            this.btnRegister.Text = "Register";
            this.btnRegister.Location = new System.Drawing.Point(20, 165);
            this.btnRegister.Width = 90;

            // btnCancel
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(130, 165);
            this.btnCancel.Width = 90;

            // chkShowPassword
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.Location = new System.Drawing.Point(20, 140);

            // RegisterForm
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.AddRange(new Control[]
            {
                txtFirstName, txtLastName, txtPassword, txtConfirmPassword,
                btnRegister, btnCancel, chkShowPassword
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Register";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Placeholder методы
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == txtFirstName && tb.Text == "First Name") tb.Text = "";
            if (tb == txtLastName && tb.Text == "Last Name") tb.Text = "";
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == txtFirstName && string.IsNullOrWhiteSpace(tb.Text)) tb.Text = "First Name";
            if (tb == txtLastName && string.IsNullOrWhiteSpace(tb.Text)) tb.Text = "Last Name";
        }
    }
}
