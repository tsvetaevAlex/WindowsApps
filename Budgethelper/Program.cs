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

            //Verify reristryfou Uid tto understand, is user works before 
            var storedUid = RegistryService.LoadUid();
            if (String.IsNullOrEmpty(storedUid))// если на ПК нет Uid а значит и базы с уже имеющимися, данными. ИНИциалиизируем работу приложения.
                                                // создаем пользователя пккпунты к которым будут привязаны транзкции (чеки), для составления отчетов в ближайшем будущем.,
            {
                Logger.SendMessage(Message_Type.User, "при запуске я не нашел артефактов работы приложения на данном компьютере\r\n" +
                    "полагаю, что это первый запуск.");
                Logger.SendMessage(Message_Type.Info,
                    ".Что мы сейчас будем делать:" +
                    "\r\n1добавим в приложение нового пользоваателя с Вашими данными.\r\n" +
                    "\r\n2.добавим Ваш первыый кошелёк и добавим источник денежных средств доступных из кошелька. Наличные / карточки.");

                // 5. Запуск  формы регистрации пользователя.
                Application.Run(new RegisterForm());
                Logger.SendMessage(Message_Type.Info, "\r\n +----------------------------------+" +
                                                      "\r\n | Регистрация нового пользователя. |" +
                                                      "\r\n +----------------------------------+");
                    Logger.SendMessage(Message_Type.User, "  - заполните пожалуйста поля формы регистрации:\" +\r\n" +
                    "\r\n -1. Имя Фамилия и пароль,поля обязательные для заполнения:\" +" +
                    "\r\n -2. если Отчество будт указано, будет приоритетно обращение по Имя Отчество, если нет, то по имени.:\" +" +
                    "\r\n -3. Используйте глоачку [x]Показать Пароль, \r\n" +
                    "\r\n -3.1. для проверки введенного ароля перепд нажатием кнопки  [Регистрация].");

                if (Session.IsAuthorized)
                {
                    WalletGroup wallet = new WalletGroup();
                    //wallet.ShowDialog();

                }
                else { }
            } // if (String.IsNullOrEmpty(storedUid))// если на ПК нет Uid 
            else
            {
                Logger.SendMessage(Message_Type.traceroute, "Budgethelper.Program.Main> Account found");
                Logger.SendMessage(Message_Type.User, "Учетная запись найдена, необходимо пойти авторизацию.");
                //вводим пароль, авторизация.
                LoginForm auth = new LoginForm();
                auth.ShowDialog();
            }
            // 2. Путь к БД
            Session.DbPath = Session.DbPath;
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
