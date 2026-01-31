using Budgethelper.Controls;
using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Budgethelper.Forms
{
    public partial class MainForm : Form
    {
        // Компоненты
        private AccountsGroup accountsGroup1;
        private TransactionsGroup transactionsGroup1;

        public MainForm()
        {
            InitializeComponent();

            // Инициализация контролов
            accountsGroup1 = new AccountsGroup();
            accountsGroup1.Location = new System.Drawing.Point(10, 10);
            accountsGroup1.Size = new System.Drawing.Size(300, 380);
            accountsGroup1.AccountSelected += AccountsGroup1_AccountSelected;
            this.Controls.Add(accountsGroup1);

            transactionsGroup1 = new TransactionsGroup();
            transactionsGroup1.Location = new System.Drawing.Point(320, 10);
            transactionsGroup1.Size = new System.Drawing.Size(780, 400);
            this.Controls.Add(transactionsGroup1);

            // Загружаем аккаунты текущего пользователя
            LoadUserAccounts();
        }

        private void LoadUserAccounts()
        {
            if (string.IsNullOrEmpty(Session.Uid))
            {
                MessageBox.Show("Сессия пользователя не установлена!");
                return;
            }

            var accounts = AccountsService.GetAccountsByUid(Session.Uid);
            if (accounts.Any())
            {
                accountsGroup1.LoadAccounts(accounts);

                // Загружаем первый аккаунт по умолчанию
                var firstAccount = accounts.First();
                transactionsGroup1.LoadAccount(firstAccount.Name);
            }
            else
            {
                transactionsGroup1.SetInactive();
            }
        }

        // Обработчик выбора аккаунта из AccountsGroup
        private void AccountsGroup1_AccountSelected(object sender, string selectedAccount)
        {
            if (!string.IsNullOrEmpty(selectedAccount))
            {
                transactionsGroup1.LoadAccount(selectedAccount);
            }
        }
    }
}
