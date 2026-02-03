namespace Budgethelper.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSureName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSureName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSureName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSureName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.btnRegister = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Text = "Имя";

            // txtName
            this.txtName.Location = new System.Drawing.Point(30, 50);
            this.txtName.Size = new System.Drawing.Size(240, 23);

            // lblSureName
            this.lblSureName.AutoSize = true;
            this.lblSureName.Location = new System.Drawing.Point(30, 85);
            this.lblSureName.Text = "Фамилия";

            // txtSureName
            this.txtSureName.Location = new System.Drawing.Point(30, 105);
            this.txtSureName.Size = new System.Drawing.Size(240, 23);

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(30, 140);
            this.lblLastName.Text = "Отчество";

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(30, 160);
            this.txtLastName.Size = new System.Drawing.Size(240, 23);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 195);
            this.lblPassword.Text = "Пароль";

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(30, 215);
            this.txtPassword.Size = new System.Drawing.Size(240, 23);
            this.txtPassword.PasswordChar = '*';

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(30, 260);
            this.btnRegister.Size = new System.Drawing.Size(240, 35);
            this.btnRegister.Text = "Зарегистрироваться";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 330);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSureName);
            this.Controls.Add(this.txtSureName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
