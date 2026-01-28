using System;
using System.Windows.Forms;
using Budgethelper.Models;
using Budgethelper.Services;
using Budgethelper.Forms;

namespace Budgethelper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1️⃣ Загружаем UID из реестра (может быть null)
            Session.Uid = RegistryService.LoadUid();

            // 2️⃣ Если UID нет — пользователь не зарегистрирован
            if (string.IsNullOrWhiteSpace(Session.Uid))
            {
                using (var registerForm = new RegisterForm())
                {
                    if (registerForm.ShowDialog() != DialogResult.OK)
                        return; // пользователь закрыл регистрацию
                }

                // UID должен быть сохранён RegistryService внутри RegisterForm
                Session.Uid = RegistryService.LoadUid();

                if (string.IsNullOrWhiteSpace(Session.Uid))
                    throw new InvalidOperationException("UID не был создан при регистрации.");
            }

            // 3️⃣ DbPath НИГДЕ НЕ ПРИСВАИВАЕТСЯ
            // он вычисляется автоматически из Session.Uid
            // string dbPath = Session.DbPath;

            // 4️⃣ Запуск главной формы
            Application.Run(new MainForm());
        }
    }
}
