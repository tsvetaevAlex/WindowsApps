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

        public MainForm()
        {
            InitializeComponent();

            // Logger
            Logger.Initialize();

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

            int requiredHeight =
                accountsGroup.Bottom +
                20 +
                transactionsGroup.Height +
                rtbStatusBar.Height +
                40;

            this.Height = requiredHeight;
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