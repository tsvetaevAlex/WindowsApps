using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public class MainForm : Form
    {
        // Tabs
        private TabControl tabControl;

        // StatusBar
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblCurrency;
        private ToolStripStatusLabel lblBalance;
        private ToolStripStatusLabel lblStatus;

        public MainForm()
        {
            Text = "BudgetHelper";
            Width = 900;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeTabs();
            InitializeStatusBar();
        }

        private void InitializeTabs()
        {
            tabControl = new TabControl
            {
                Dock = DockStyle.Fill
            };

            tabControl.TabPages.Add(CreateTab("Счета"));
            tabControl.TabPages.Add(CreateTab("Транзакции"));
            tabControl.TabPages.Add(CreateTab("Статистика"));

            Controls.Add(tabControl);
        }

        private TabPage CreateTab(string title)
        {
            return new TabPage
            {
                Text = title
            };
        }

        private void InitializeStatusBar()
        {
            statusStrip = new StatusStrip();

            lblUser = new ToolStripStatusLabel("Пользователь: —");
            lblCurrency = new ToolStripStatusLabel("Валюта: —");
            lblBalance = new ToolStripStatusLabel("Баланс: 0.00");
            lblStatus = new ToolStripStatusLabel("Готово");

            statusStrip.Items.Add(lblUser);
            statusStrip.Items.Add(new ToolStripSeparator());
            statusStrip.Items.Add(lblCurrency);
            statusStrip.Items.Add(new ToolStripSeparator());
            statusStrip.Items.Add(lblBalance);
            statusStrip.Items.Add(new ToolStripSeparator());
            statusStrip.Items.Add(lblStatus);

            Controls.Add(statusStrip);
        }

        // ===== Публичные методы для будущей логики =====

        public void SetUser(string userName)
        {
            lblUser.Text = $"Пользователь: {userName}";
        }

        public void SetCurrency(string currency)
        {
            lblCurrency.Text = $"Валюта: {currency}";
        }

        public void SetBalance(decimal balance)
        {
            lblBalance.Text = $"Баланс: {balance:F2}";
        }

        public void SetStatus(string text)
        {
            lblStatus.Text = text;
        }
    }
}
