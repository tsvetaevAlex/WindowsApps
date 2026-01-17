using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class RegisterForm
    {
        private TableLayoutPanel table;
        private Label lblFirstName;
        private Label lblSurname;
        private Label lblPatronymic;
        private Label lblPassword;
        private TextBox txtFirstName;
        private TextBox txtSurname;
        private TextBox txtPatronymic;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Button btnRegister;

        private void InitializeComponent()
        {
            this.table = new TableLayoutPanel();
            this.lblFirstName = new Label();
            this.lblSurname = new Label();
            this.lblPatronymic = new Label();
            this.lblPassword = new Label();
            this.txtFirstName = new TextBox();
            this.txtSurname = new TextBox();
            this.txtPatronymic = new TextBox();
            this.txtPassword = new TextBox();
            this.chkShowPassword = new CheckBox();
            this.btnRegister = new Button();

            this.SuspendLayout();

            // table
            this.table.ColumnCount = 2;
            this.table.RowCount = 6;
            this.table.Dock = DockStyle.Fill;
            this.table.Padding = new Padding(15);
            this.table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));

            for (int i = 0; i < 6; i++)
                this.table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

            // labels
            lblFirstName.Text = "Имя:";
            lblSurname.Text = "Фамилия:";
            lblPatronymic.Text = "Отчество:";
            lblPassword.Text = "Пароль:";

            lblFirstName.TextAlign =
            lblSurname.TextAlign =
            lblPatronymic.TextAlign =
            lblPassword.TextAlign = ContentAlignment.MiddleLeft;

            // password
            txtPassword.UseSystemPasswordChar = true;

            // checkbox
            chkShowPassword.Text = "Показать";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            // button
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.Click += btnRegister_Click;
            btnRegister.Dock = DockStyle.Right;

            // layout
            table.Controls.Add(lblFirstName, 0, 0);
            table.Controls.Add(txtFirstName, 1, 0);

            table.Controls.Add(lblSurname, 0, 1);
            table.Controls.Add(txtSurname, 1, 1);

            table.Controls.Add(lblPatronymic, 0, 2);
            table.Controls.Add(txtPatronymic, 1, 2);

            table.Controls.Add(lblPassword, 0, 3);
            table.Controls.Add(txtPassword, 1, 3);

            table.Controls.Add(chkShowPassword, 1, 4);
            table.Controls.Add(btnRegister, 1, 5);

            // form
            this.Controls.Add(table);
            this.ClientSize = new Size(420, 240);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя";

            this.ResumeLayout(false);
        }
    }
}
