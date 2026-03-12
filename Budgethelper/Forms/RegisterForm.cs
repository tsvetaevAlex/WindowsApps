using Budgethelper.Models;
using Budgethelper.Services;
using Microsoft.Win32;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            SqlService.Initialize_Database();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtSureName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заполните все Обязательнве поля: [Имя],[ФАмилия], [Пароль]");
                return;
            }

            string uid = Guid.NewGuid().ToString();
            string passwordHash = HashService.GetHash(txtPassword.Text);

            Session.Uid = uid;
            Session.DbPath = $"{uid}.sqlite";
            SqlService.Initialize_Database(); //create TUser table

            var user = new User(
                uid,
                txtName.Text,
                txtSureName.Text,
                txtLastName.Text,
                passwordHash
            );
            Session.CurrentUser = user;

            SqlService.CreateUser(user); //save user data ti YUser table

            Session.CurrentUser = user; //save user details to session 
                                        //keep data closer reduce QTY of requests to DB
            Session.IsAuthorized = true;

            //non-volatile storage of read quick access
            RegistryService.SaveUid(uid); // save uid to windows registry.
                                            
            MessageBox.Show("Регистрация завершена");

            Hide();

            new MainForm().Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
