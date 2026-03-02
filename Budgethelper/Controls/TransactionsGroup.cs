using Budgethelper.Models;
using Budgethelper.Services;
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

            rtbTransact_QTY.Text = "0";
            cbOperationType.DataSource = Enum.GetValues(typeof(TransactionType));

            rtbTransact_QTY.SelectAll();
            rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
            tbTransactQTY.TextAlign = HorizontalAlignment.Right;
            rtbTransact_QTY.DeselectAll();

            InitializeGrid();
        }

        #region Grid

        private void InitializeGrid()
        {
            dgvSessionStats.AutoGenerateColumns = false;
            dgvSessionStats.Columns.Clear();

            dgvSessionStats.Columns.Add("Id", "Id");
            dgvSessionStats.Columns.Add("Date", "DateTime");
            dgvSessionStats.Columns.Add("AccountName", "Account");
            dgvSessionStats.Columns.Add("Amount", "Amount");
            dgvSessionStats.Columns.Add("Type", "Type");
            dgvSessionStats.Columns.Add("Description", "Comment");

            dgvSessionStats.ReadOnly = true;
            dgvSessionStats.BringToFront();
            dgvSessionStats.AllowUserToAddRows = false;
            dgvSessionStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadTransactionsToGrid()
        {
            if (_currentAccount == null)
                return;

            dgvSessionStats.Rows.Clear();

            var transactions = SqlService.GetTransactions(_currentAccount.AccountID);

            foreach (var t in transactions)
            {
                int rowIndex = dgvSessionStats.Rows.Add(
                    t.Id,
                    t.Date.ToString("yyyy-MM-dd HH:mm"),
                    _currentAccount.AccountName,
                    t.Amount,
                    t.OperationType.ToString(),
                    t.Description
                );

                if (t.OperationType == TransactionType.Income)
                    dgvSessionStats.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;
                else
                    dgvSessionStats.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
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
                CurrentTransaction = GetTransactionFromInputs();

                int newId = SqlService.CreateTransaction(
                    CurrentTransaction.AccountId,
                    CurrentTransaction.Date,
                    CurrentTransaction.Amount,
                    (int)CurrentTransaction.OperationType,
                    CurrentTransaction.Description);

                // --- SESSION COUNTERS ---

                Session.TransactQTY++;
                string loggerMsg = $"Транзакция: $ID[{newId}]  | {CurrentTransaction.OperationType}, на сумму: {CurrentTransaction.Amount}, добавлена.";
                if (CurrentTransaction.OperationType == TransactionType.Income)
                {
                    Session.Income_TransactQTY++;
                    Session.Income_Totalbalance += CurrentTransaction.Amount;
                    Session.overallbalance += CurrentTransaction.Amount;
                    Logger.SendMessage(MessageType.TransactionIncome, loggerMsg);
                }
                else
                {
                    Session.Expense_TransactQTY++;
                    Session.Expense_Totalbalance += CurrentTransaction.Amount;
                    Session.overallbalance -= CurrentTransaction.Amount;
                    Logger.SendMessage(MessageType.TransactionExpence, loggerMsg);
                }

                rtbTransact_QTY.Text = Session.TransactQTY.ToString();
                rtbTransact_QTY.SelectAll();
                rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
                rtbTransact_QTY.DeselectAll();

                UpdateSEssionStats();
                if (CurrentTransaction.OperationType == TransactionType.Income)
                    Logger.SendMessage(MessageType.TransactionIncome, loggerMsg);
                else
                    Logger.SendMessage(MessageType.TransactionExpence, loggerMsg);
                LoadTransactionsToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        //Utils
        #region Utils

        public void TransactionsGroup_RandomDataFiller()
        {
            if (_currentAccount == null)
                return;

            Random random = new Random();

            // Дата
            if (random.Next(0, 2) == 0)
                datePicker.Value = DateTime.Today.AddDays(-1);
            else
                datePicker.Value = DateTime.Today;

            // Сумма
            tbAmount.Text = random.Next(55, 1751).ToString();

            // Тип операции
            cbOperationType.SelectedIndex = random.Next(0, 1);

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

            rtbTransactStats.SelectionColor = Color.White;
            rtbTransactStats.AppendText(
                $"Общее число транзакций: {Session.TransactQTY} " +
                $"Общий баланс: {Session.overallbalance}{Environment.NewLine}");

            rtbTransactStats.SelectionColor = Color.Lime;
            rtbTransactStats.AppendText(
                $"Income транзакции: {Session.Income_TransactQTY} " +
                $"Income общая сумма: {Session.Income_Totalbalance}{Environment.NewLine}");

            rtbTransactStats.SelectionColor = Color.Red;
            rtbTransactStats.AppendText(
                $"Expense транзакции: {Session.Expense_TransactQTY} " +
                $"Expense общая сумма: {Session.Expense_Totalbalance}{Environment.NewLine}");
        }


        public void SetAccount(Account account)
        {
            if (account == null)
                return;

            _currentAccount = account;
            Session.CurrentAccount = account;

            TranzactGroup_tbAccountName.Text = account.AccountName;

            UpdateSEssionStats();
            LoadTransactionsToGrid();
        }



        public Transaction GetTransactionFromInputs()
        {
            if (!decimal.TryParse(tbAmount.Text, out decimal amount))
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

    }
}