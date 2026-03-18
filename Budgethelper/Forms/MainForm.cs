using Budgethelper.Controls;
using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        private WalletGroup _WalletGroup;
        private TransactionsGroup _transactionsGroup;

        private Timer resizeTimer;
        private Size targetSize;

        private const int Step = 25;

        public MainForm()
        {
            InitializeComponent();

            resizeTimer = new Timer();
            resizeTimer.Interval = 10;
            resizeTimer.Tick += resizeTimer_Tick;

            InitUserControls();

            // стартовый размер
            ApplySizeForCurrentTab(false);
        }

        private void InitUserControls()
        {
            _WalletGroup = new WalletGroup();
            _transactionsGroup = new TransactionsGroup();

            _WalletGroup.Location = new Point(0, 0);
            _transactionsGroup.Location = new Point(0, 0);

            MainForm_WalletTab.Controls.Add(_WalletGroup);
            MainForm_TransactionsTab.Controls.Add(_transactionsGroup);

            MainForm_WalletTab.AutoScroll = false;
            MainForm_TransactionsTab.AutoScroll = false;
        }

        private void MainForm_tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logger.SendMessage(MessageType.UI,
                $"Вы перешли на закладку: [{MainForm_tabs.SelectedIndex}]: \"{MainForm_tabs.SelectedTab.Text}\"");

            ApplySizeForCurrentTab(true);
        }

        private void ApplySizeForCurrentTab(bool animate)
        {
            if (MainForm_tabs.SelectedTab.Controls.Count == 0)
                return;

            Control activeControl = MainForm_tabs.SelectedTab.Controls[0];

            int widthDiff = MainForm_tabs.Width - MainForm_tabs.DisplayRectangle.Width;
            int heightDiff = MainForm_tabs.Height - MainForm_tabs.DisplayRectangle.Height;

            int tabW = activeControl.Width + widthDiff;
            int tabH = activeControl.Height + heightDiff;

            MainForm_tabs.Size = new Size(tabW, tabH);

            targetSize = new Size(
                MainForm_tabs.Left + tabW,
                MainForm_tabs.Top + tabH
            );

            if (animate)
                resizeTimer.Start();
            else
                this.ClientSize = targetSize;
        }

        private void resizeTimer_Tick(object sender, EventArgs e)
        {
            int curW = this.ClientSize.Width;
            int curH = this.ClientSize.Height;

            if (Math.Abs(curW - targetSize.Width) > Step)
                curW += (targetSize.Width > curW) ? Step : -Step;
            else
                curW = targetSize.Width;

            if (Math.Abs(curH - targetSize.Height) > Step)
                curH += (targetSize.Height > curH) ? Step : -Step;
            else
                curH = targetSize.Height;

            this.ClientSize = new Size(curW, curH);

            if (curW == targetSize.Width && curH == targetSize.Height)
                resizeTimer.Stop();
        }
    }
}