using Budgethelper.Forms;
using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
            Logger.Initialize();
            Application.Run(new MainForm());
            Logger.SendMessage(MessageType.Info, "Logger started.");
            //Logger.SendMessage(Models.MessageType.Debug, "App,Loaded,", Color.Lime);
        }
    }
}
