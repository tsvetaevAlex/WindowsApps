using Budgethelper.Forms;
using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Читаем Uid из реестра
                var savedUid = RegistryService.LoadUid();

                if (!string.IsNullOrEmpty(savedUid))
                {
                    // Пытаемся загрузить пользователя из БД
                    var user = SqlService.LoadUserByUid(savedUid);

                    if (user != null)
                    {
                        // Инициализируем сессию
                        Session.CurrentUser = user;
                        Session.Uid = user.Uid;
                        Session.IsAuthorized = true;

                        Application.Run(new MainForm());
                        return;
                    }
                }

                // Если Uid нет или пользователь не найден
                Application.Run(new RegisterForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка запуска приложения:\n{ex.Message}",
                    "BudgetHelper",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
