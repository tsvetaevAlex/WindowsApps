using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class AccountsGroup : UserControl
    {
        #region public Events
        public event Action<Account> AccountSelected;
        public event Action RequestRandomDataFill;
        #endregion

        public AccountsGroup()
        {
            InitializeComponent();

            AcSelTab_tbHeader.Text = Session.User_ToString();

            Logger.SendMessage(MessageType.UI, "AccountsGroup инициализирован.");

            AcSelTab_cbACcountsListSelector.SelectedIndexChanged
                += AcSelTab_cbACcountsListSelector_SelectedIndexChanged;

            LoadAccounts();
        }

        private void LoadAccounts()
        {
            AcSelTab_cbACcountsListSelector.DataSource = null;

            if (!Session.IsAuthorized)
            {
                Logger.SendMessage(MessageType.Warn, "Попытка загрузки аккаунтов без авторизации.");
                return;
            }

            if (Session.AccountsList == null || Session.AccountsList.Count == 0)
            {
                Logger.SendMessage(MessageType.Info, "Список аккаунтов пуст.");
                return;
            }

            AcSelTab_cbACcountsListSelector.DataSource = Session.AccountsList;
            AcSelTab_cbACcountsListSelector.DisplayMember = "AccountName";
            AcSelTab_cbACcountsListSelector.ValueMember = "AccountID";
            AcSelTab_cbACcountsListSelector.SelectedIndex = 0;

            Logger.SendMessage(MessageType.Account, "Список аккаунтов загружен.");
        }

        private void AcSelTab_cbACcountsListSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AcSelTab_cbACcountsListSelector.SelectedItem is Account account)
            {
                AcSelTab_tbAccbalanse.Text = account.Balance.ToString("0.00");
                AcSelTab_tbAccComent.Text = account.Description;

                Logger.SendMessage(MessageType.Account,
                    $"Выбран аккаунт ID[{account.AccountID}] {account.AccountName}");

                AccountSelected?.Invoke(account);

                RequestRandomDataFill?.Invoke();
            }
        }

        private void bAddAccount_Click(object sender, EventArgs e)
        {
            Logger.SendMessage(MessageType.UI, "Нажата кнопка добавления аккаунта.");

            if (string.IsNullOrWhiteSpace(tbAccName.Text) ||
                string.IsNullOrWhiteSpace(tbAccDescription.Text) ||
                string.IsNullOrWhiteSpace(tbAccBalance.Text))
            {
                Logger.SendMessage(MessageType.Warn, "Попытка создания аккаунта с незаполненными полями.");
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (!decimal.TryParse(tbAccBalance.Text, out decimal balance))
            {
                Logger.SendMessage(MessageType.Warn, "Введён некорректный баланс.");
                MessageBox.Show("Некорректный баланс");
                return;
            }

            var account = new Account
            {
                AccountName = tbAccName.Text.Trim(),
                Balance = balance,
                Description = tbAccDescription.Text.Trim()
            };

            SqlService.CreateAccount(account);

            Logger.SendMessage(MessageType.Account,
                $"Создан новый аккаунт: {account.AccountName}, баланс: {balance}");

            tbAccName.Clear();
            tbAccDescription.Clear();
            tbAccBalance.Clear();

            LoadAccounts();

            if (Session.AccountsList != null && Session.AccountsList.Count > 0)
                AcSelTab_cbACcountsListSelector.SelectedIndex =
                    Session.AccountsList.Count - 1;
        }

        private void btnRandomData_Click(object sender, EventArgs e)
        {
            Logger.SendMessage(MessageType.Transaction, "Запрошена генерация тестовых данных.");
            RequestRandomDataFill?.Invoke();
        }
    }
}