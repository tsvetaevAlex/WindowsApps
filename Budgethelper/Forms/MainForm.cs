using Budgethelper.Controls;
using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        private StatusBarService _statusBar;
        //private const int Y_indent = 20;
        //private const int X_indent = 20;
        //ULC is Upper Left Cormer (Drawing start point)
        //private Point accGrpULC =  new Point(20, 20);
        //private Point trGrpHeight = new Point(20, X_indent + AccountsGroup.Height);
        //private Point MainFormHeight = new Point(20, Y_indent + AccountsGroup.Height +  Y_indent + TransactionsGroup.Height + Yindent);
        /*
        //                  main form width 1190
        +------------------------------------------------+
        | Y indent 20                                    |
        +------------------------------------------------+
        |X indent 20 |  20naccountsGroup  | X indent 20  | <== naccountsGroup width 760 / Height
        +------------------------------------------------+
        |Y indent 20                                     |
        +------------------------------------------------+
        |X indent 20 | ntransactionsGroup |X indent 20   | <== ntransactionsGroup width 800 / Height
        +------------------------------------------------+
        |Y indent 20                                     | 
        +------------------------------------------------+
        */

        public MainForm()
        {
            InitializeComponent();
            //accGrpHeight = accountsGroup.Height;        
            //trGrpHeight = transactionsGroup.Height;
            //MainHeight = this.Height;   
            //MessageBox.Show($"mainform height: {MainHeight}\r\naccountsGroup.Height: {accGrpHeight}\r\ntransactionsGroup.Height:{trGrpHeight}");

            // Logger
            Logger.Initialize();

            //MessageBox.Show($"naccountsGroup" +
            //    $"width: {accountsGroup.Width} | Height: {accountsGroup.Height}\rn\" + ntransactionsGroup\r\n"+
            //    $"width: {transactionsGroup.Width} | Height{transactionsGroup.Height}");

            Logger.SendMessage(MessageType.Info, "MainForm loaded");

            // -------------------------------
            // Подписка на события AccountsGroup
            // -------------------------------

            // Когда выбран аккаунт — передаём его TransactionsGroup
            accountsGroup.AccountSelected += AccountsGroup_AccountSelected;

            // Когда AccountsGroup просит сгенерировать случайные данные — вызываем TransactionsGroup_RandomDataFiller
            accountsGroup.RequestRandomDataFill += transactionsGroup.TransactionsGroup_RandomDataFiller;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _statusBar = new StatusBarService(rtbStatusBar);
            _statusBar.Start();

            int neededHeight =
                accountsGroup.Bottom +
                20 +
                transactionsGroup.Height +
                rtbStatusBar.Height +
                40;

            this.Height = neededHeight;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _statusBar?.Dispose();
            base.OnFormClosing(e);
        }

        // -------------------------------
        // Обработчики событий
        // -------------------------------
        private void AccountsGroup_AccountSelected(Account account)
        {
            // Передаём выбранный аккаунт в TransactionsGroup
            transactionsGroup.SetAccount(account);

            // transactionsGroup автоматически заполняем тестовыми данными
            transactionsGroup.TransactionsGroup_RandomDataFiller();
        }

    }
}