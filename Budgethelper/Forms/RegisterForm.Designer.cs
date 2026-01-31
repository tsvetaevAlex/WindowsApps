namespace Budgethelper.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurename;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblPassword;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurename;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.CheckBox cbShowPassword;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblName = new System.Windows.Forms.Label();
            this.lblSurename = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurename = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 20);
            this.lblName.Text = "Имя *";

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 17);
            this.txtName.Size = new System.Drawing.Size(200, 23);

            // 
            // lblSurename
            // 
            this.lblSurename.AutoSize = true;
            this.lblSurename.Location = new System.Drawing.Point(30, 60);
            this.lblSurename.Text = "Фамилия *";

            // 
            // txtSurename
            // 
            this.txtSurename.Location = new System.Drawing.Point(150, 57);
            this.txtSurename.Size = new System.Drawing.Size(200, 23);

            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(30, 100);
            this.lblLastname.Text = "Отчество *";

            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(150, 97);
            this.txtLastname.Size = new System.Drawing.Size(200, 23);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 140);
            this.lblPassword.Text = "Пароль *";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 137);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // cbShowPassword
            // 
            this.cbShowPassword.Location = new System.Drawing.Point(150, 170);
            this.cbShowPassword.Text = "Показать пароль";
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);

            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(150, 210);
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurename);
            this.Controls.Add(this.txtSurename);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
