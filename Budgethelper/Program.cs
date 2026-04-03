using Budgethelper.Controls;
using Budgethelper.Forms;
using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Инициализация логгера
            Logger.Initialize();
            Session.IsAuthorized = true;

            //Verify reristryfou Uid tto understand, is user works before 
            var storedUid = RegistryService.LoadUid();
            if (String.IsNullOrEmpty(storedUid))// если на ПК нет Uid а значит и базы с уже имеющимися, данными. ИНИциалиизируем работу приложения.
                                                // создаем пользователя пккпунты к которым будут привязаны транзкции (чеки), для составления отчетов в ближайшем будущем.,
            {
                Logger.SendMessage(Message_Type.User, "при запуске я не нашел артефактов работы приложения на данном компьютере\r\n" +
                    "полагаю, что это первый запуск.");
                Logger.SendMessage(Message_Type.Info, 
                    "\r\n1.Что мы сделаем это добавим  в приложение нового пользоваателя с Вашими данными.\r\n" +
                    "\r\n2.Начало работы, будет создание Вашего первого кошелька и добавление источников денежных средств доступных из кошелька. Наличные / карточки." +
                    "\r\n - заполните пожалуйста поля формы регистрации:" +
                    "\r\n - Имя Фамилия и пароль,поля обязательные для заполнения:" +
                    "\r\n - если Отчество будт указано, будет приоритетно обращение по Имя Отчество, если нет, то по имени.:" +
                    "\r\n - Используйте глоачку [x]Показать Пароль," +
                    "\r\n   для проверки введенного ароля перепд нажатием кнопки  [Регистрация]."); 

                // 5. Запуск  формы регистрации пользователя.
                Application.Run(new RegisterForm());

                //вводим пароль, авторизация.
                LoginForm auth = new LoginForm();
                auth.ShowDialog();

                if (Session.IsAuthorized)
                {
                    WalletGroup wallet = new WalletGroup();
                    //wallet.ShowDialog();

                }
                else { }
            }

            // 2. Путь к БД
            Session.DbPath = "budgethelper.db";
            Session.dropAccounts();
            // 3. Инициализация базы
            SqlService.Initialize_Database();
            SqlService.LoadAccountsToSession(0); // Session.AccountsList = GetAccounts();

            // 4. Сообщение о запуске
            Logger.SendMessage(Message_Type.Info,"Application started");

            // 5. Запуск главной формы
            Application.Run(new MainForm());
        }
    }
}
