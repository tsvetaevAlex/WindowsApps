using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;

        private Label lblName;
        private Label lblSurname;
        private Label lblLastName;
        private Label lblPassword;
        private Label lblConfirmPassword;

        private Label lblNameRequired;
        private Label lblSurnameRequired;

        private Button btnRegister;
        private Button btnCancel;
        private CheckBox chkShowPassword;

        private ToolTip toolTip;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip = new ToolTip(components);

            txtName = new TextBox();
            txtSurname = new TextBox();
            txtLastName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();

            lblName = new Label();
            lblSurname = new Label();
            lblLastName = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();

            lblNameRequired = new Label();
            lblSurnameRequired = new Label();

            btnRegister = new Button();
            btnCancel = new Button();
            chkShowPassword = new CheckBox();

            // Form
            this.ClientSize = new Size(300, 380);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Register";

            int labelX = 20;
            int inputX = 150;
            int y = 20;
            int verticalSpacing = 35;
            int textBoxWidth = 120;

            // Name
            lblName.Text = "Name:";
            lblName.Location = new Point(labelX, y);
            lblName.AutoSize = true;

            lblNameRequired.Text = "*";
            lblNameRequired.ForeColor = Color.Red;
            lblNameRequired.Location = new Point(labelX + 50, y);
            lblNameRequired.AutoSize = true;

            txtName.Location = new Point(inputX, y - 3);
            txtName.Width = textBoxWidth;
            txtName.Text = "Enter name";

            y += verticalSpacing;

            // Surname
            lblSurname.Text = "Surname:";
            lblSurname.Location = new Point(labelX, y);
            lblSurname.AutoSize = true;

            lblSurnameRequired.Text = "*";
            lblSurnameRequired.ForeColor = Color.Red;
            lblSurnameRequired.Location = new Point(labelX + 70, y);
            lblSurnameRequired.AutoSize = true;

            txtSurname.Location = new Point(inputX, y - 3);
            txtSurname.Width = textBoxWidth;
            txtSurname.Text = "Enter surname";

            y += verticalSpacing;

            // Last Name
            lblLastName.Text = "Last Name (optional):";
            lblLastName.Location = new Point(labelX, y);
            lblLastName.AutoSize = true;

            txtLastName.Location = new Point(inputX, y - 3);
            txtLastName.Width = textBoxWidth;
            txtLastName.Text = "Enter last name (optional)";

            y += verticalSpacing;

            // Password
            lblPassword.Text = "Password:";
            lblPassword.Location = new Point(labelX, y);
            lblPassword.AutoSize = true;

            txtPassword.Location = new Point(inputX, y - 3);
            txtPassword.Width = textBoxWidth;
            txtPassword.PasswordChar = '●';

            y += verticalSpacing;

            // Confirm Password
            lblConfirmPassword.Text = "Confirm Password:";
            lblConfirmPassword.Location = new Point(labelX, y);
            lblConfirmPassword.AutoSize = true;

            txtConfirmPassword.Location = new Point(inputX, y - 3);
            txtConfirmPassword.Width = textBoxWidth;
            txtConfirmPassword.PasswordChar = '●';

            y += verticalSpacing + 10;

            // Show Password Checkbox
            chkShowPassword.Text = "Show password";
            chkShowPassword.Location = new Point(labelX, y);
            chkShowPassword.AutoSize = true;

            y += verticalSpacing;

            // Buttons
            btnRegister.Text = "Register";
            btnRegister.Location = new Point(labelX, y);
            btnRegister.Width = 100;

            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(labelX + 120, y);
            btnCancel.Width = 100;

            // Add controls
            this.Controls.AddRange(new Control[]
            {
                lblName, lblNameRequired, txtName,
                lblSurname, lblSurnameRequired, txtSurname,
                lblLastName, txtLastName,
                lblPassword, txtPassword,
                lblConfirmPassword, txtConfirmPassword,
                chkShowPassword,
                btnRegister, btnCancel
            });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
    }
}
