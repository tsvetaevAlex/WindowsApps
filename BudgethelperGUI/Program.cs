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

            using (var register = new RegisterForm())
            {
                if (register.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new MainForm());
        }
    }
}
