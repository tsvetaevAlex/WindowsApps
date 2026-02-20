using Budgethelper.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        private Account _currentAccount;
        private Transaction CurrentTransaction = null;

        public TransactionsGroup()
        {
            InitializeComponent();

            // Настройка UI
            rtbTransact_QTY.Text = "0";
            cbOperationType.DataSource = Enum.GetValues(typeof(TransactionType));

            rtbTransact_QTY.SelectAll();
            rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
            tbTransactQTY.TextAlign = HorizontalAlignment.Right;
            rtbTransact_QTY.DeselectAll();
        }

        #region Utils

        public void SetAccount(Account account)
        {
            if (account == null)
                return;

            _currentAccount = account;
            Session.CurrentAccount = account;

            TranzactGroup_tbAccountName.Text = account.AccountName;

            UpdateSEssionStats();
        }

        public Transaction GetTransactionFromInputs()
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
                throw new Exception("Сумма введена неверно.");

            if (_currentAccount == null)
                throw new Exception("Аккаунт не выбран.");

            return new Transaction
            {
                AccountId = _currentAccount.AccountID,
                Date = datePicker.Value,
                Amount = amount,
                OperationType = (TransactionType)cbOperationType.SelectedItem,
                Description = txtDescription.Text
            };
        }

        #endregion

        #region Event handlers

        private void BtnToday_Click(object sender, EventArgs e)
            => datePicker.Value = DateTime.Today;

        private void BtnYesterday_Click(object sender, EventArgs e)
            => datePicker.Value = DateTime.Today.AddDays(-1);

        private void bAddTransact_Click(object sender, EventArgs e)
        {
            if (_currentAccount == null)
            {
                MessageBox.Show("Выберите аккаунт.");
                return;
            }

            try
            {
                // Если нужен автоген тестовых данных
                TransactionsGroup_RandomDataFiller();

                CurrentTransaction = GetTransactionFromInputs();
                decimal amount = CurrentTransaction.Amount;

                // ---- ОБЩИЙ СЧЁТЧИК ----
                Session.TransactQTY++;

                // ---- INCOME / EXPENSE ----
                if (CurrentTransaction.OperationType == TransactionType.Income)
                {
                    Session.Income_TransactQTY++;
                    Session.Income_Totalbalance += amount;
                    Session.overallbalance += amount;
                }
                else
                {
                    Session.Expense_TransactQTY++;
                    Session.Expense_Totalbalance += amount;
                    Session.overallbalance -= amount;
                }

                // ---- Обновление UI счётчика ----
                rtbTransact_QTY.Text = Session.TransactQTY.ToString();
                rtbTransact_QTY.SelectAll();
                rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
                rtbTransact_QTY.DeselectAll();

                // ---- Обновляем статистику ----
                UpdateSEssionStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void TransactionsGroup_RandomDataFiller()
        {
            if (_currentAccount == null)
                return;

            Random random = new Random();

            // Дата
            if (random.Next(0, 2) == 0)
                BtnYesterday_Click(this, EventArgs.Empty);
            else
                BtnToday_Click(this, EventArgs.Empty);

            // Сумма
            txtAmount.Text = random.Next(55, 1751).ToString();

            // Тип операции
            cbOperationType.SelectedIndex = random.Next(0, 2);

            // Описание
            const string chars = " абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            char[] text = new char[25];
            for (int i = 0; i < 25; i++)
                text[i] = chars[random.Next(chars.Length)];

            txtDescription.Text = new string(text);
        }

        private void UpdateSEssionStats()
        {
            if (_currentAccount == null)
                return;

            rtbTransactStats.Clear();

            // Общая статистика
            rtbTransactStats.SelectionColor = Color.White;
            rtbTransactStats.AppendText(
                $"Общее число транзакций: {Session.TransactQTY}" +
                $"Общий баланс: {Session.overallbalance}{Environment.NewLine}");

            // Доходы
            rtbTransactStats.SelectionColor = Color.Lime;
            rtbTransactStats.AppendText(
                $"Income транзакции: {Session.Income_TransactQTY}" +
                $"Income сумма: {Session.Income_Totalbalance}{Environment.NewLine}");

            // Расходы
            rtbTransactStats.SelectionColor = Color.Red;
            rtbTransactStats.AppendText(
                $"Expense транзакции: {Session.Expense_TransactQTY}" +
                $"Expense сумма: {Session.Expense_Totalbalance}{Environment.NewLine}");
        }

        #endregion
    }
}