using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Visual.Logger
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            StartVisualLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VisualLogger());
        }

        private static void StartVisualLogger()
        {
            try
            {
                string exeName = "Visual.Logger.exe";

                string source = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\..\Visual.Logger\bin\Debug",
                    exeName);

                source = Path.GetFullPath(source);

                string target = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    exeName);

                if (!File.Exists(target))
                    File.Copy(source, target, true);

                bool alreadyRunning = Process.GetProcessesByName("Visual.Logger").Any();
                if (!alreadyRunning)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = target,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Не удалось запустить Visual.Logger\n\n" + ex.Message,
                    "Logger error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
