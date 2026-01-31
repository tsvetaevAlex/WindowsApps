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
        private System.Windows.Forms.CheckBox cbShowPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblName = new System.Windows.Forms.Label();
            this.lblSureName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();

            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSureName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.btnRegister = new System.Windows.Forms.Button();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();

            this.SuspendLayout();

            // 
            // Labels
            // 
            this.lblSureName.Text = "Фамилия*";
            this.lblSureName.ForeColor = System.Drawing.Color.Red;
            this.lblSureName.Location = new System.Drawing.Point(10, 10);
            this.lblSureName.AutoSize = true;

            this.txtSureName.Location = new System.Drawing.Point(10, 30);
            this.txtSureName.Width = 300;

            this.lblName.Text = "Имя*";
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(10, 60);
            this.lblName.AutoSize = true;

            this.txtName.Location = new System.Drawing.Point(10, 80);
            this.txtName.Width = 300;

            this.lblLastName.Text = "Отчество";
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(10, 110);
            this.lblLastName.AutoSize = true;

            this.txtLastName.Location = new System.Drawing.Point(10, 130);
            this.txtLastName.Width = 300;

            this.lblPassword.Text = "Пароль*";
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(10, 160);
            this.lblPassword.AutoSize = true;

            this.txtPassword.Location = new System.Drawing.Point(10, 180);
            this.txtPassword.Width = 300;
            this.txtPassword.PasswordChar = '●';

            // 
            // Button и CheckBox (нижний ряд)
            // 
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.Location = new System.Drawing.Point(10, 220);
            this.btnRegister.Width = 200;

            this.cbShowPassword.Text = "Показать";
            this.cbShowPassword.Location = new System.Drawing.Point(220, 220);
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);

            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(330, 260);
            this.Controls.Add(this.lblSureName);
            this.Controls.Add(this.txtSureName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbShowPassword);

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
