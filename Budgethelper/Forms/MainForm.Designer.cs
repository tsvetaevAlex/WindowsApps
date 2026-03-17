using Budgethelper.Controls;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl MainForm_tabs;
        private TabPage MainForm_WalletTab;
        private TabPage MainForm_TransactionsTab;
        private WalletGroup _WalletGroup = new WalletGroup();
        private TransactionsGroup _transactionsGroup = new TransactionsGroup();
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.MainForm_tabs = new System.Windows.Forms.TabControl();
            this.MainForm_WalletTab = new System.Windows.Forms.TabPage();
            this.MainForm_TransactionsTab = new System.Windows.Forms.TabPage();
            this.MainForm_tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm_tabs
            // 
            this.MainForm_tabs.Controls.Add(this.MainForm_WalletTab);
            this.MainForm_tabs.Controls.Add(this.MainForm_TransactionsTab);
            this.MainForm_tabs.Location = new System.Drawing.Point(10, 10);
            this.MainForm_tabs.Name = "MainForm_tabs";
            this.MainForm_tabs.SelectedIndex = 0;
            this.MainForm_tabs.Size = new System.Drawing.Size(675, 450);
            this.MainForm_tabs.TabIndex = 0;
            this.MainForm_tabs.SelectedIndexChanged += new System.EventHandler(this.MainForm_tabs_TabIndexChanged);
            this.MainForm_tabs.TabIndexChanged += new System.EventHandler(this.MainForm_tabs_TabIndexChanged);
            // 
            // MainForm_WalletTab
            // 
            this.MainForm_WalletTab.Location = new System.Drawing.Point(4, 22);
            this.MainForm_WalletTab.Name = "MainForm_WalletTab";
            this.MainForm_WalletTab.Size = new System.Drawing.Size(667, 424);
            this.MainForm_WalletTab.TabIndex = 0;
            this.MainForm_WalletTab.Text = "Кошелёк";
            // 
            // MainForm_TransactionsTab
            // 
            this.MainForm_TransactionsTab.Location = new System.Drawing.Point(4, 22);
            this.MainForm_TransactionsTab.Name = "MainForm_TransactionsTab";
            this.MainForm_TransactionsTab.Size = new System.Drawing.Size(667, 424);
            this.MainForm_TransactionsTab.TabIndex = 1;
            this.MainForm_TransactionsTab.Text = "Транзакции";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.MainForm_tabs);
            this.Name = "MainForm";
            this.Text = "BudgetHelper";
            this.MainForm_tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}