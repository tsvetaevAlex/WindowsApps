using Budgethelper.Models;
using Budgethelper.Services;
using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            Logger.SendMessage(Message_Type.traceroute, "RegisterForm");
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
            Logger.SendMessage(Message_Type.User,$"Вaм присвоен ID: {uid}");
            string passwordHash = HashService.GetHash(txtPassword.Text);

            Session.Uid = uid;
            //Session.DbPath = $"{uid}.sqlite";
            string roamingAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Session.DbPath = Path.Combine(roamingAppDataPath + "_Budgethelper", "{uid}.sqlite");

            Logger.SendMessage(Message_Type.Debug, $"roaming AppData Folder Path: {roamingAppDataPath}");
            Logger.SendMessage(Message_Type.traceroute, $"appliction db file: {Session.DbPath}");

            SqlService.Initialize_Database(); //create TUser table

            var user = new UserModel(
                uid,
                txtName.Text,
                txtSureName.Text,
                txtLastName.Text,
                passwordHash
            );
            SqlService.CreateUser(user); //save user data to TUser table

            Session.CurrentUser = user; //save user details to session 
                                        //keep data closer reduce QTY of requests to DB
            Session.IsAuthorized = true;

            //non-volatile storage of read quick access
            RegistryService.SaveUid(user); // save uid to windows registry.

            Logger.SendMessage(Message_Type.Success, "Регистрация успешно завершена");
            MessageBox.Show("Регистрация успешно завершена");

            Hide();

            new MainForm().Show();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
