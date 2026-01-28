using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtName;
        private TextBox txtSureName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private Button btnRegister;
        private CheckBox cbShowPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new TextBox();
            this.txtSureName = new TextBox();
            this.txtLastName = new TextBox();
            this.txtPassword = new TextBox();
            this.btnRegister = new Button();
            this.cbShowPassword = new CheckBox();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // txtSureName
            this.txtSureName.Location = new System.Drawing.Point(20, 50);
            this.txtSureName.Name = "txtSureName";
            this.txtSureName.Size = new System.Drawing.Size(200, 23);

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(20, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 23);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(20, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            // cbShowPassword
            this.cbShowPassword.Location = new System.Drawing.Point(230, 110);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(120, 23);
            this.cbShowPassword.Text = "Показать пароль";
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(20, 150);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSureName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
