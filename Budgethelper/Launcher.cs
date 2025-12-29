using System;
using System.Windows.Forms;
using Visual.Logger.Server;

namespace Visual.Logger.GUI.Server
{
    public static class Launcher
    {
        public static void RunLogger()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VisualLoggerForm());
        }
    }
}
