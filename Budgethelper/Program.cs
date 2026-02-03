using System;
using System.Windows.Forms;
using Budgethelper.Forms;
using Budgethelper.Models;
using Budgethelper.Services;

namespace Budgethelper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var savedUid = RegistryService.LoadUid();

            if (!string.IsNullOrEmpty(savedUid))
            {
                Session.Uid = savedUid;
                Session.DbPath = $"{savedUid}.sqlite";

                var user = SqlService.LoadUserByUid(savedUid);
                if (user != null)
                {
                    Session.CurrentUser = user;
                    Session.IsAuthorized = true;
                    Application.Run(new MainForm());
                    return;
                }
            }

            Application.Run(new RegisterForm());
        }
    }
}
