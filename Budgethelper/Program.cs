using System;
using System.Windows.Forms;
using Visual.Logger.Server;
using System.ServiceModel;

namespace BudgethelperGUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем и показываем VisualLogger
            VisualLoggerForm visualLogger = new VisualLoggerForm();
            visualLogger.Show();

            // Запускаем WCF-сервис логгера
            ServiceHost host = visualLogger.StartService();

            // Лог стартового сообщения
            visualLogger.SendMessage("Приложение запущено. Логгер готов к работе.");

            // Создаем и показываем главную форму
            BudgethelperGUIForm mainForm = new BudgethelperGUIForm(visualLogger);
            Application.Run(mainForm);

            // Закрываем WCF-сервис при выходе
            host.Close();
        }
    }
}
