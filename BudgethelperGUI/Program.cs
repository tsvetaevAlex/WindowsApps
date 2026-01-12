using System;
using System.Windows.Forms;
using Budgethelper.Forms;

namespace Budgethelper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаем проверку регистрации
            var registerForm = new RegisterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}

