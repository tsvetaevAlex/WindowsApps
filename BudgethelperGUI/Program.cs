using BudgetHelper.Services;
using Visual.Logger;
namespace Budgethelper
{
    internal static class Program
    {
        [System.STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            // === Visual.Logger ===
            VisualLogger logger =
                new VisualLogger();
            logger.Show();

            // === Registry ===
            if (!Budgethelper.Services.RegistryService.UserExists())
            {
                System.Windows.Forms.Application.Run(
                    new Budgethelper.Forms.RegisterForm()
                );
                return;
            }

            string uid = Budgethelper.Services.RegistryService.GetUid();

            // === SqlService (AppServices) ===
            BudgetHelper.Services.SqlService sql =
                new BudgetHelper.Services.SqlService(uid);

            // === Main UI ===
            System.Windows.Forms.Application.Run(
                new Budgethelper.Forms.MainForm()
            );
        }
    }
}
