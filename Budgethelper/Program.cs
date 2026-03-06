using System;
using System.Drawing;
using System.Windows.Forms;
using Budgethelper.Services;
using Budgethelper.Forms;
using Budgethelper.Models;

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
                Logger.SendMessage(MessageType.User, "при запуске я не нашел артефактов работы приложения на данном компьютере\r\n" +
                    "полагаю это первый запуск.");
                Logger.SendMessage(MessageType.Info, "Первое, что мы сделаем это добавим  в приложение нового пользоваателя с Вашими данными.\\r\n" +
                    "вторым этапом начала работы, будет создание ВАшего первого кошелька и добавление источников денежных средств доступных из кошелька. Наличные / карточки.");
                // 5. Запуск  формы регистрации пользователя.
                Application.Run(new RegisterForm());

                //вводим пароль, авторизация.
                LoginForm auth = new LoginForm();
                auth.ShowDialog();

                if (Session.IsAuthorized)
                {
                    WalletForm wallet = new WalletForm();
                    wallet.ShowDialog();

                }
                else { }
            }

            // 2. Путь к БД
            Session.DbPath = "budgethelper.db";
            Session.dropAccounts();
            // 3. Инициализация базы
            SqlService.Initialize_Database();
            SqlService.LoadAccountsToSession(); // Session.AccountsList = GetAccounts();

            // 4. Сообщение о запуске
            Logger.SendMessage(MessageType.Info,"Application started");

            // 5. Запуск главной формы
            Application.Run(new MainForm());
        }
    }
}
