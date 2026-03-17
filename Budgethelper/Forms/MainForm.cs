using Budgethelper.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        private WalletGroup walletGroup;
        private TransactionsGroup transactionsGroup;

        public MainForm()
        {
            InitializeComponent();
            this.MainForm_tabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InitUserControls();
        }
        private void InitUserControls()
        {
            // Создаём контролы
            _WalletGroup.Location = new System.Drawing.Point(0, 0);
            _transactionsGroup.Location = new System.Drawing.Point(0, 0);

            // Добавляем в TabPage
            MainForm_WalletTab.Controls.Add(_WalletGroup);
            MainForm_TransactionsTab.Controls.Add(_transactionsGroup);

            // Вычисляем максимальный размер
            int maxWidth = Math.Max(_WalletGroup.Width, _transactionsGroup.Width);
            int maxHeight = Math.Max(_WalletGroup.Height, _transactionsGroup.Height);

            // Подгоняем размер TabControl и формы под UserControl
            MainForm_tabs.Size = new System.Drawing.Size(maxWidth, maxHeight);
            this.ClientSize = new System.Drawing.Size(
                MainForm_tabs.Location.X + maxWidth + 10,  // +10 для отступа справа
                MainForm_tabs.Location.Y + maxHeight + 10  // +10 для отступа снизу
            );
        }

        private void MainForm_tabs_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"SelectedIndex: [{this.MainForm_tabs.SelectedIndex}]\r\n" +
                $"SelectedTab.Text: [{this.MainForm_tabs.SelectedTab.Text}]");
        }
        /*
private void InitUserControls()
{
   walletGroup = new WalletGroup();
   int wg_Width = walletGroup.walletGroup_WIdth;
   int wg_jeight = walletGroup.walletGroup_Height;
   transactionsGroup = new TransactionsGroup();
   int tr_Width = transactionsGroup.transactionsGroup_WIdth;
   int tr_jeight = transactionsGroup.transactionsGroup_Height;
   walletGroup.Location = new Point(10, 10);
   transactionsGroup.Location = new Point(10, 10);
   var max_WIdth = Math.Max(wg_Width, tr_Width);
   var max_Height = Math.Max(wg_jeight, tr_jeight);
   this.ClientSize = new Size(wg_Width, wg_jeight);
   MainForm_WalletTab.Controls.Add(walletGroup);
   MainForm_TransactionsTab.Controls.Add(transactionsGroup);
}*/
    }// end of partial class MainForm
}// end of namespace Budgethelper.Forms