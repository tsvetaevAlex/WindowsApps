using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        private StatusBarService _statusBar;

        public MainForm()
        {
            InitializeComponent();


            Logger.Initialize();
            Logger.SendMessage(MessageType.Info, "MainForm loaded");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.Initialize();

            _statusBar = new StatusBarService(rtbStatusBar);
            _statusBar.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _statusBar?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
