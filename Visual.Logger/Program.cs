using System;
using System.Windows.Forms;
using Visual.Logger.Forms;

namespace Visual.Logger
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VisualLoggerForm());
        }
    }
}
