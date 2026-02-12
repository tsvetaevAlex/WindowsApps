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

            // 2. Путь к БД
            Session.DbPath = "budgethelper.db";

            // 3. Инициализация базы
            SqlService.Initialize_Database();

            // 4. Сообщение о запуске
            Logger.SendMessage("Application started",Color.Lime);

            // 5. Запуск главной формы
            Application.Run(new MainForm());
        }
    }
}
