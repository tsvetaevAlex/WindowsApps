using System;
using System.Windows.Forms;
using Budgethelper.Forms;
using Visual.Logger.Forms;

namespace Budgethelper
{
    internal static class Program
    {
        public static VisualLoggerForm Logger; // ← ВАЖНО

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Logger = new VisualLoggerForm();
            Logger.Show();

            using (var register = new RegisterForm())
            {
                if (register.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new MainForm());
        }
    }
}
