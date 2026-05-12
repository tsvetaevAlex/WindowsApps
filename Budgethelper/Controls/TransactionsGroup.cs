using Budgethelper.Models;
using Budgethelper.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class TransactionsGroup : UserControl
    {
        public int transactionsGroup_WIdth { get; set; }
        public int transactionsGroup_Height { get; set; }
        
        //TRG_groupBox_AddNewAccount
        private AccountModel _currentAccount;
        private Transaction _сurrentTransaction = null;

        public TransactionsGroup()
        {

            InitializeComponent();
            transactionsGroup_WIdth = this.Width;
            transactionsGroup_Height = this.Height;
            rtbTransact_QTY.Text = "0";
            cbOperationType.DataSource = Enum.GetValues(typeof(TransactionType));

            rtbTransact_QTY.SelectAll();
            rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
            rtbTransact_QTY.DeselectAll();

            InitializeGrid();
        }

        #region Grid

        private void InitializeGrid()
        {
            TRG_dataGridView.AutoGenerateColumns = false;
            TRG_dataGridView.Columns.Clear();

            TRG_dataGridView.Columns.Add("Id", "Id");
            TRG_dataGridView.Columns.Add("Date", "DateTime");
            TRG_dataGridView.Columns.Add("AccountName", "Account");
            TRG_dataGridView.Columns.Add("Amount", "Amount");
            TRG_dataGridView.Columns.Add("Type", "Type");
            TRG_dataGridView.Columns.Add("Description", "Comment");

            TRG_dataGridView.ReadOnly = true;
            TRG_dataGridView.BringToFront();
            TRG_dataGridView.AllowUserToAddRows = false;
            TRG_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadTransactionsToGrid()
        {
            if (_currentAccount == null)
                return;

            TRG_dataGridView.Rows.Clear();

            var transactions = SqlService.GetTransactions(_currentAccount.AccountID);

            foreach (var t in transactions)
            {
                int rowIndex = TRG_dataGridView.Rows.Add(
                    t.Id,
                    t.Date.ToString("yyyy-MM-dd HH:mm"),
                    _currentAccount.AccountName,
                    t.Amount,
                    t.OperationType.ToString(),
                    t.Description
                );

                if (t.OperationType == TransactionType.Income)
                    TRG_dataGridView.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;
                else
                    TRG_dataGridView.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Red;
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
                _сurrentTransaction = GetTransactionFromInputs();
                int newId = SqlService.CreateTransaction(_сurrentTransaction);

                // --- SESSION COUNTERS ---

                Session.TransactionQTY++;
                string loggerMsg = $"Транзакция: $ID[{newId}]  | {_сurrentTransaction.OperationType}, на сумму: {_сurrentTransaction.Amount}, добавлена.";
                if (_сurrentTransaction.OperationType == TransactionType.Income)
                {
                    Session.Income_TransactQTY++;
                    Session.Income_Totalbalance += _сurrentTransaction.Amount;
                    Session.overallbalance += _сurrentTransaction.Amount;
                    Logger.SendMessage(Message_Type.TransactionIncome, loggerMsg);
                }
                else
                {
                    Session.Expense_TransactQTY++;
                    Session.Expense_Totalbalance += _сurrentTransaction.Amount;
                    Session.overallbalance -= _сurrentTransaction.Amount;
                    Logger.SendMessage(Message_Type.TransactionExpence, loggerMsg);
                }

                rtbTransact_QTY.Text = Session.TransactionQTY.ToString();
                rtbTransact_QTY.SelectAll();
                rtbTransact_QTY.SelectionAlignment = HorizontalAlignment.Right;
                rtbTransact_QTY.DeselectAll();

                UpdateSEssionStats();
                if (_сurrentTransaction.OperationType == TransactionType.Income)
                    Logger.SendMessage(Message_Type.TransactionIncome, loggerMsg);
                else
                    Logger.SendMessage(Message_Type.TransactionExpence, loggerMsg);
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


            /*
            TRG_dataGridView.Clear();

            TRG_dataGridView.SelectionColor = Color.White;
            TRG_dataGridView.AppendText(
                $"Общее число транзакций: {Session.TransactQTY} " +
                $"Общий баланс: {Session.overallbalance}{Environment.NewLine}");

            TRG_dataGridView.SelectionColor = Color.Lime;
            TRG_dataGridView.AppendText(
                $"Income транзакции: {Session.Income_TransactQTY} " +
                $"Income общая сумма: {Session.Income_Totalbalance}{Environment.NewLine}");

            TRG_dataGridView.SelectionColor = Color.Red;
            TRG_dataGridView.AppendText(
                $"Expense транзакции: {Session.Expense_TransactQTY} " +
                $"Expense общая сумма: {Session.Expense_Totalbalance}{Environment.NewLine}");
            */
        }


        public void SetAccount(AccountModel account)
        {
            if (account == null)
                return;

            _currentAccount = account;
            Session.currentAccount = account;

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

        private void TransactionsGroup_Load(object sender, EventArgs e)
        {


        }


        //==============================
        //Events
        //==============================
        #region Events
        private void TRG_button_AddNewAccount_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.TRG_groupBox_AddNewAccount.Visible = true;
            this.ResumeLayout(true);
        }

        private void TRG_TextBox_NewAccountName_MouseEnter(object sender, EventArgs e)
        {
            if (this.TRG_TextBox_NewAccountName.CanFocus)
            {
                this.TRG_TextBox_NewAccountName.Text = string.Empty;
            }
        }

        private void TRG_textBox_NewAccountBalanse_MouseEnter(object sender, EventArgs e)
        {
            if (this.TRG_textBox_NewAccountBalanse.CanFocus)
            {
                this.TRG_textBox_NewAccountBalanse.Text = string.Empty;
            }
        }

        private void TRG_textBox_NewAccountDescription_MouseEnter(object sender, EventArgs e)
        {
            if (this.TRG_textBox_NewAccountDescription.CanFocus)
            {
                this.TRG_textBox_NewAccountDescription.Text = string.Empty;
            }
        }

        private void TRG_comboBox_NewACcountType_Click(object sender, EventArgs e)
        {
            TRG_comboBox_NewACcountType.DataSource = Enum.GetValues(typeof(FundsSource_Type));
        }

        #endregion

    }

}