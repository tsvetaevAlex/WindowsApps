using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgethelperGUI.Services;

namespace BudgethelperGUI.Forms
{
    partial class MainForm : Form
    {
        private readonly StatusBarService _statusBar;

        public MainForm()
        {
            InitializeComponent();
            _statusBar = new StatusBarService(rtbFooter);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _statusBar.Start();
        }
    }
}
