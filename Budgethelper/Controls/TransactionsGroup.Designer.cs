using System.Windows.Forms;

namespace Budgethelper.Controls
{
    partial class TransactionsGroup
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbOperationType;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnToday;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblAccountName = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbOperationType = new System.Windows.Forms.ComboBox();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.TranzactGroup_tbAccountName = new System.Windows.Forms.TextBox();
            this.lbTransactDate = new System.Windows.Forms.Label();
            this.lbTransactAmount = new System.Windows.Forms.Label();
            this.TransactType = new System.Windows.Forms.Label();
            this.trabsactComment = new System.Windows.Forms.Label();
            this.TRG_bAddTransact = new System.Windows.Forms.Button();
            this.TRG_GroupBox_SessionStats = new System.Windows.Forms.GroupBox();
            this.TRG_groupBox_AddBewAccount = new System.Windows.Forms.GroupBox();
            this.TRG_textBox_NewAccountDescription = new System.Windows.Forms.TextBox();
            this.TRG_textBox_NewAccountBalanse = new System.Windows.Forms.TextBox();
            this.TRG_comboBox_NewACcountType = new System.Windows.Forms.ComboBox();
            this.TRG_TextBox_NewAccountName = new System.Windows.Forms.TextBox();
            this.TRG_SessionStats_RichTextBox_Overal_Balanse = new System.Windows.Forms.TextBox();
            this.TRG_SessionStats_Label_OveralTransactionsQTY = new System.Windows.Forms.Label();
            this.TRG_GroupBox_SessionStats_TotalAmount = new System.Windows.Forms.GroupBox();
            this.TRG_label_NewAccount_ExpeseTotal = new System.Windows.Forms.Label();
            this.TRG_label_NewAccount_IncomeTotal = new System.Windows.Forms.Label();
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse = new System.Windows.Forms.RichTextBox();
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse = new System.Windows.Forms.RichTextBox();
            this.TRG_GroupBox_SessionStats_Transaction_QTY = new System.Windows.Forms.GroupBox();
            this.TRG_RichTextBox_IncomeQTY = new System.Windows.Forms.RichTextBox();
            this.TRG_RichTextBox_ExpenseQTY = new System.Windows.Forms.RichTextBox();
            this.TRG_Label_IncomeQTY = new System.Windows.Forms.Label();
            this.GB_SуssionStats_label_transactions_QTY = new System.Windows.Forms.Label();
            this.TRG_SessionStats_Label_transactionsQTY = new System.Windows.Forms.Label();
            this.rtbTransact_QTY = new System.Windows.Forms.RichTextBox();
            this.YRG_button_AddNewAccpunt = new System.Windows.Forms.Button();
            this.TRG_dataGridView = new System.Windows.Forms.DataGridView();
            this.TRG_comboBox_Header_AccountSElector = new System.Windows.Forms.ComboBox();
            this.TRG_Button_Header_AccpuntSelect = new System.Windows.Forms.Button();
            this.TRG_GroupBox_SessionStats.SuspendLayout();
            this.TRG_groupBox_AddBewAccount.SuspendLayout();
            this.TRG_GroupBox_SessionStats_TotalAmount.SuspendLayout();
            this.TRG_GroupBox_SessionStats_Transaction_QTY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRG_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(20, 85);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(78, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(110, 105);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 20);
            this.datePicker.TabIndex = 2;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(240, 105);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(460, 105);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // cbOperationType
            // 
            this.cbOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Location = new System.Drawing.Point(350, 105);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(100, 21);
            this.cbOperationType.TabIndex = 7;
            // 
            // btnYesterday
            // 
            this.btnYesterday.Location = new System.Drawing.Point(110, 130);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(60, 25);
            this.btnYesterday.TabIndex = 4;
            this.btnYesterday.Text = "Вчера";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.BtnYesterday_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(170, 130);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(60, 25);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Сегодня";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // TranzactGroup_tbAccountName
            // 
            this.TranzactGroup_tbAccountName.Location = new System.Drawing.Point(20, 105);
            this.TranzactGroup_tbAccountName.Name = "TranzactGroup_tbAccountName";
            this.TranzactGroup_tbAccountName.Size = new System.Drawing.Size(80, 20);
            this.TranzactGroup_tbAccountName.TabIndex = 1;
            // 
            // lbTransactDate
            // 
            this.lbTransactDate.AutoSize = true;
            this.lbTransactDate.Location = new System.Drawing.Point(120, 85);
            this.lbTransactDate.Name = "lbTransactDate";
            this.lbTransactDate.Size = new System.Drawing.Size(83, 13);
            this.lbTransactDate.TabIndex = 10;
            this.lbTransactDate.Text = "transaction date";
            // 
            // lbTransactAmount
            // 
            this.lbTransactAmount.Location = new System.Drawing.Point(240, 85);
            this.lbTransactAmount.Name = "lbTransactAmount";
            this.lbTransactAmount.Size = new System.Drawing.Size(100, 13);
            this.lbTransactAmount.TabIndex = 11;
            this.lbTransactAmount.Text = "transaction amount";
            // 
            // TransactType
            // 
            this.TransactType.AutoSize = true;
            this.TransactType.Location = new System.Drawing.Point(350, 85);
            this.TransactType.Name = "TransactType";
            this.TransactType.Size = new System.Drawing.Size(89, 13);
            this.TransactType.TabIndex = 12;
            this.TransactType.Text = "income | expense";
            // 
            // trabsactComment
            // 
            this.trabsactComment.AutoSize = true;
            this.trabsactComment.Location = new System.Drawing.Point(460, 85);
            this.trabsactComment.Name = "trabsactComment";
            this.trabsactComment.Size = new System.Drawing.Size(105, 13);
            this.trabsactComment.TabIndex = 13;
            this.trabsactComment.Text = "transaction comment";
            // 
            // TRG_bAddTransact
            // 
            this.TRG_bAddTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRG_bAddTransact.Location = new System.Drawing.Point(615, 105);
            this.TRG_bAddTransact.Name = "TRG_bAddTransact";
            this.TRG_bAddTransact.Size = new System.Drawing.Size(100, 48);
            this.TRG_bAddTransact.TabIndex = 9;
            this.TRG_bAddTransact.Text = "Добавить Транзакцию";
            this.TRG_bAddTransact.UseVisualStyleBackColor = true;
            this.TRG_bAddTransact.Click += new System.EventHandler(this.bAddTransact_Click);
            // 
            // TRG_GroupBox_SessionStats
            // 
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_groupBox_AddBewAccount);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_SessionStats_RichTextBox_Overal_Balanse);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_SessionStats_Label_OveralTransactionsQTY);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_GroupBox_SessionStats_TotalAmount);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_GroupBox_SessionStats_Transaction_QTY);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_SessionStats_Label_transactionsQTY);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.rtbTransact_QTY);
            this.TRG_GroupBox_SessionStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_GroupBox_SessionStats.Location = new System.Drawing.Point(600, 159);
            this.TRG_GroupBox_SessionStats.Name = "TRG_GroupBox_SessionStats";
            this.TRG_GroupBox_SessionStats.Size = new System.Drawing.Size(400, 445);
            this.TRG_GroupBox_SessionStats.TabIndex = 19;
            this.TRG_GroupBox_SessionStats.TabStop = false;
            this.TRG_GroupBox_SessionStats.Text = "Краткая сводка Текущей Сессии";
            // 
            // TRG_groupBox_AddBewAccount
            // 
            this.TRG_groupBox_AddBewAccount.Controls.Add(this.TRG_textBox_NewAccountDescription);
            this.TRG_groupBox_AddBewAccount.Controls.Add(this.TRG_textBox_NewAccountBalanse);
            this.TRG_groupBox_AddBewAccount.Controls.Add(this.TRG_comboBox_NewACcountType);
            this.TRG_groupBox_AddBewAccount.Controls.Add(this.TRG_TextBox_NewAccountName);
            this.TRG_groupBox_AddBewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_groupBox_AddBewAccount.Location = new System.Drawing.Point(20, 290);
            this.TRG_groupBox_AddBewAccount.Name = "TRG_groupBox_AddBewAccount";
            this.TRG_groupBox_AddBewAccount.Size = new System.Drawing.Size(370, 145);
            this.TRG_groupBox_AddBewAccount.TabIndex = 11;
            this.TRG_groupBox_AddBewAccount.TabStop = false;
            this.TRG_groupBox_AddBewAccount.Text = "Добавить новый Аккаунт";
            this.TRG_groupBox_AddBewAccount.Visible = false;
            // 
            // TRG_textBox_NewAccountDescription
            // 
            this.TRG_textBox_NewAccountDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_textBox_NewAccountDescription.Location = new System.Drawing.Point(140, 51);
            this.TRG_textBox_NewAccountDescription.Name = "TRG_textBox_NewAccountDescription";
            this.TRG_textBox_NewAccountDescription.Size = new System.Drawing.Size(170, 20);
            this.TRG_textBox_NewAccountDescription.TabIndex = 26;
            this.TRG_textBox_NewAccountDescription.Text = "введите котроткое описание";
            this.TRG_textBox_NewAccountDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TRG_textBox_NewAccountDescription.MouseEnter += new System.EventHandler(this.TRG_textBox_NewAccountDescription_MouseEnter);
            // 
            // TRG_textBox_NewAccountBalanse
            // 
            this.TRG_textBox_NewAccountBalanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_textBox_NewAccountBalanse.Location = new System.Drawing.Point(160, 20);
            this.TRG_textBox_NewAccountBalanse.Name = "TRG_textBox_NewAccountBalanse";
            this.TRG_textBox_NewAccountBalanse.Size = new System.Drawing.Size(150, 20);
            this.TRG_textBox_NewAccountBalanse.TabIndex = 25;
            this.TRG_textBox_NewAccountBalanse.Text = "Укажите баланс";
            this.TRG_textBox_NewAccountBalanse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TRG_textBox_NewAccountBalanse.MouseEnter += new System.EventHandler(this.TRG_textBox_NewAccountBalanse_MouseEnter);
            // 
            // TRG_comboBox_NewACcountType
            // 
            this.TRG_comboBox_NewACcountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_comboBox_NewACcountType.FormattingEnabled = true;
            this.TRG_comboBox_NewACcountType.Location = new System.Drawing.Point(10, 50);
            this.TRG_comboBox_NewACcountType.Name = "TRG_comboBox_NewACcountType";
            this.TRG_comboBox_NewACcountType.Size = new System.Drawing.Size(120, 21);
            this.TRG_comboBox_NewACcountType.TabIndex = 24;
            this.TRG_comboBox_NewACcountType.Text = "Income / Expense";
            this.TRG_comboBox_NewACcountType.Click += new System.EventHandler(this.TRG_comboBox_NewACcountType_Click);
            // 
            // TRG_TExtBox_NewAccountName
            // 
            this.TRG_TextBox_NewAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_TextBox_NewAccountName.Location = new System.Drawing.Point(10, 20);
            this.TRG_TextBox_NewAccountName.Name = "TRG_TextBox_NewAccountName";
            this.TRG_TextBox_NewAccountName.Size = new System.Drawing.Size(140, 21);
            this.TRG_TextBox_NewAccountName.TabIndex = 23;
            this.TRG_TextBox_NewAccountName.Text = "Имя ноаого Аккаунта";
            this.TRG_TextBox_NewAccountName.MouseEnter += new System.EventHandler(this.TRG_TextBox_NewAccountName_MouseEnter);
            // 
            // TRG_SessionStats_RichTextBox_Overal_Balanse
            // 
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.Location = new System.Drawing.Point(243, 50);
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.Name = "TRG_SessionStats_RichTextBox_Overal_Balanse";
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.ReadOnly = true;
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.Size = new System.Drawing.Size(100, 21);
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.TabIndex = 35;
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.TabStop = false;
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.Text = "123456";
            this.TRG_SessionStats_RichTextBox_Overal_Balanse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TRG_SessionStats_Label_OveralTransactionsQTY
            // 
            this.TRG_SessionStats_Label_OveralTransactionsQTY.AutoSize = true;
            this.TRG_SessionStats_Label_OveralTransactionsQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_SessionStats_Label_OveralTransactionsQTY.Location = new System.Drawing.Point(259, 23);
            this.TRG_SessionStats_Label_OveralTransactionsQTY.Name = "TRG_SessionStats_Label_OveralTransactionsQTY";
            this.TRG_SessionStats_Label_OveralTransactionsQTY.Size = new System.Drawing.Size(81, 26);
            this.TRG_SessionStats_Label_OveralTransactionsQTY.TabIndex = 36;
            this.TRG_SessionStats_Label_OveralTransactionsQTY.Text = "Общая сумма \r\n транзакций:";
            // 
            // TRG_GroupBox_SessionStats_TotalAmount
            // 
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.TRG_label_NewAccount_ExpeseTotal);
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.TRG_label_NewAccount_IncomeTotal);
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse);
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse);
            this.TRG_GroupBox_SessionStats_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_GroupBox_SessionStats_TotalAmount.Location = new System.Drawing.Point(220, 125);
            this.TRG_GroupBox_SessionStats_TotalAmount.Name = "TRG_GroupBox_SessionStats_TotalAmount";
            this.TRG_GroupBox_SessionStats_TotalAmount.Size = new System.Drawing.Size(170, 155);
            this.TRG_GroupBox_SessionStats_TotalAmount.TabIndex = 35;
            this.TRG_GroupBox_SessionStats_TotalAmount.TabStop = false;
            this.TRG_GroupBox_SessionStats_TotalAmount.Text = "Общая сумма";
            // 
            // TRG_label_NewAccount_ExpeseTotal
            // 
            this.TRG_label_NewAccount_ExpeseTotal.AutoSize = true;
            this.TRG_label_NewAccount_ExpeseTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_label_NewAccount_ExpeseTotal.Location = new System.Drawing.Point(20, 92);
            this.TRG_label_NewAccount_ExpeseTotal.Name = "TRG_label_NewAccount_ExpeseTotal";
            this.TRG_label_NewAccount_ExpeseTotal.Size = new System.Drawing.Size(121, 13);
            this.TRG_label_NewAccount_ExpeseTotal.TabIndex = 5;
            this.TRG_label_NewAccount_ExpeseTotal.Text = "Оющая сумма Exprnse";
            // 
            // TRG_label_NewAccount_IncomeTotal
            // 
            this.TRG_label_NewAccount_IncomeTotal.AutoSize = true;
            this.TRG_label_NewAccount_IncomeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_label_NewAccount_IncomeTotal.Location = new System.Drawing.Point(20, 26);
            this.TRG_label_NewAccount_IncomeTotal.Name = "TRG_label_NewAccount_IncomeTotal";
            this.TRG_label_NewAccount_IncomeTotal.Size = new System.Drawing.Size(116, 13);
            this.TRG_label_NewAccount_IncomeTotal.TabIndex = 4;
            this.TRG_label_NewAccount_IncomeTotal.Text = "Общая сумма Income";
            // 
            // TRG_SessionStats_RichTextBox_Overal_Income_Balanse
            // 
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.ForeColor = System.Drawing.Color.GhostWhite;
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.Location = new System.Drawing.Point(20, 45);
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.Name = "TRG_SessionStats_RichTextBox_Overal_Income_Balanse";
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.Size = new System.Drawing.Size(100, 25);
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.TabIndex = 3;
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.TabStop = false;
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse.Text = "12569.67";
            // 
            // TRG_SessionStats_RichTextBox_Overal_Expense_Balanse
            // 
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.BackColor = System.Drawing.Color.Salmon;
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.ForeColor = System.Drawing.Color.GhostWhite;
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.Location = new System.Drawing.Point(20, 120);
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.Name = "TRG_SessionStats_RichTextBox_Overal_Expense_Balanse";
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.Size = new System.Drawing.Size(100, 25);
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.TabIndex = 2;
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.TabStop = false;
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse.Text = "123.45";
            // 
            // TRG_GroupBox_SessionStats_Transaction_QTY
            // 
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.TRG_RichTextBox_IncomeQTY);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.TRG_RichTextBox_ExpenseQTY);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.TRG_Label_IncomeQTY);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.GB_SуssionStats_label_transactions_QTY);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Location = new System.Drawing.Point(20, 125);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Name = "TRG_GroupBox_SessionStats_Transaction_QTY";
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Size = new System.Drawing.Size(190, 155);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.TabIndex = 34;
            this.TRG_GroupBox_SessionStats_Transaction_QTY.TabStop = false;
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Text = "Количество транзакций";
            // 
            // TRG_RichTextBox_IncomeQTY
            // 
            this.TRG_RichTextBox_IncomeQTY.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TRG_RichTextBox_IncomeQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_RichTextBox_IncomeQTY.ForeColor = System.Drawing.Color.GhostWhite;
            this.TRG_RichTextBox_IncomeQTY.Location = new System.Drawing.Point(20, 45);
            this.TRG_RichTextBox_IncomeQTY.Name = "TRG_RichTextBox_IncomeQTY";
            this.TRG_RichTextBox_IncomeQTY.ReadOnly = true;
            this.TRG_RichTextBox_IncomeQTY.Size = new System.Drawing.Size(100, 25);
            this.TRG_RichTextBox_IncomeQTY.TabIndex = 5;
            this.TRG_RichTextBox_IncomeQTY.TabStop = false;
            this.TRG_RichTextBox_IncomeQTY.Text = "95";
            // 
            // TRG_RichTextBox_ExpenseQTY
            // 
            this.TRG_RichTextBox_ExpenseQTY.BackColor = System.Drawing.Color.Salmon;
            this.TRG_RichTextBox_ExpenseQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_RichTextBox_ExpenseQTY.ForeColor = System.Drawing.Color.GhostWhite;
            this.TRG_RichTextBox_ExpenseQTY.Location = new System.Drawing.Point(20, 120);
            this.TRG_RichTextBox_ExpenseQTY.Name = "TRG_RichTextBox_ExpenseQTY";
            this.TRG_RichTextBox_ExpenseQTY.Size = new System.Drawing.Size(100, 25);
            this.TRG_RichTextBox_ExpenseQTY.TabIndex = 4;
            this.TRG_RichTextBox_ExpenseQTY.TabStop = false;
            this.TRG_RichTextBox_ExpenseQTY.Text = "123";
            // 
            // TRG_Label_IncomeQTY
            // 
            this.TRG_Label_IncomeQTY.AutoSize = true;
            this.TRG_Label_IncomeQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_Label_IncomeQTY.Location = new System.Drawing.Point(20, 20);
            this.TRG_Label_IncomeQTY.Name = "TRG_Label_IncomeQTY";
            this.TRG_Label_IncomeQTY.Size = new System.Drawing.Size(165, 13);
            this.TRG_Label_IncomeQTY.TabIndex = 6;
            this.TRG_Label_IncomeQTY.Text = "Income количество транзакций";
            // 
            // GB_SуssionStats_label_transactions_QTY
            // 
            this.GB_SуssionStats_label_transactions_QTY.AutoSize = true;
            this.GB_SуssionStats_label_transactions_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_SуssionStats_label_transactions_QTY.Location = new System.Drawing.Point(20, 80);
            this.GB_SуssionStats_label_transactions_QTY.Name = "GB_SуssionStats_label_transactions_QTY";
            this.GB_SуssionStats_label_transactions_QTY.Size = new System.Drawing.Size(127, 26);
            this.GB_SуssionStats_label_transactions_QTY.TabIndex = 0;
            this.GB_SуssionStats_label_transactions_QTY.Text = "количество транзакций\r\n расхода";
            // 
            // TRG_SessionStats_Label_transactionsQTY
            // 
            this.TRG_SessionStats_Label_transactionsQTY.AutoSize = true;
            this.TRG_SessionStats_Label_transactionsQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRG_SessionStats_Label_transactionsQTY.Location = new System.Drawing.Point(40, 23);
            this.TRG_SessionStats_Label_transactionsQTY.Name = "TRG_SessionStats_Label_transactionsQTY";
            this.TRG_SessionStats_Label_transactionsQTY.Size = new System.Drawing.Size(163, 13);
            this.TRG_SessionStats_Label_transactionsQTY.TabIndex = 32;
            this.TRG_SessionStats_Label_transactionsQTY.Text = "общее количество транзакций";
            // 
            // rtbTransact_QTY
            // 
            this.rtbTransact_QTY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(91)))), ((int)(((byte)(122)))));
            this.rtbTransact_QTY.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbTransact_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTransact_QTY.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbTransact_QTY.Location = new System.Drawing.Point(43, 50);
            this.rtbTransact_QTY.Name = "rtbTransact_QTY";
            this.rtbTransact_QTY.ReadOnly = true;
            this.rtbTransact_QTY.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTransact_QTY.Size = new System.Drawing.Size(180, 60);
            this.rtbTransact_QTY.TabIndex = 25;
            this.rtbTransact_QTY.TabStop = false;
            this.rtbTransact_QTY.Text = "12345";
            // 
            // YRG_button_AddNewAccpunt
            // 
            this.YRG_button_AddNewAccpunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YRG_button_AddNewAccpunt.Location = new System.Drawing.Point(723, 20);
            this.YRG_button_AddNewAccpunt.Name = "YRG_button_AddNewAccpunt";
            this.YRG_button_AddNewAccpunt.Size = new System.Drawing.Size(100, 48);
            this.YRG_button_AddNewAccpunt.TabIndex = 27;
            this.YRG_button_AddNewAccpunt.Text = "Добавить новый аккаунт";
            this.YRG_button_AddNewAccpunt.UseVisualStyleBackColor = true;
            this.YRG_button_AddNewAccpunt.Click += new System.EventHandler(this.YRG_button_AddNewAccpunt_Click);
            // 
            // TRG_dataGridView
            // 
            this.TRG_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TRG_dataGridView.Location = new System.Drawing.Point(20, 165);
            this.TRG_dataGridView.Name = "TRG_dataGridView";
            this.TRG_dataGridView.Size = new System.Drawing.Size(550, 440);
            this.TRG_dataGridView.TabIndex = 20;
            // 
            // TRG_comboBox_Header_AccountSElector
            // 
            this.TRG_comboBox_Header_AccountSElector.FormattingEnabled = true;
            this.TRG_comboBox_Header_AccountSElector.Location = new System.Drawing.Point(20, 20);
            this.TRG_comboBox_Header_AccountSElector.Name = "TRG_comboBox_Header_AccountSElector";
            this.TRG_comboBox_Header_AccountSElector.Size = new System.Drawing.Size(590, 21);
            this.TRG_comboBox_Header_AccountSElector.TabIndex = 21;
            // 
            // TRG_Button_Header_AccpuntSelect
            // 
            this.TRG_Button_Header_AccpuntSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TRG_Button_Header_AccpuntSelect.Location = new System.Drawing.Point(615, 17);
            this.TRG_Button_Header_AccpuntSelect.Name = "TRG_Button_Header_AccpuntSelect";
            this.TRG_Button_Header_AccpuntSelect.Size = new System.Drawing.Size(100, 48);
            this.TRG_Button_Header_AccpuntSelect.TabIndex = 22;
            this.TRG_Button_Header_AccpuntSelect.Text = "подтвердить выбор";
            this.TRG_Button_Header_AccpuntSelect.UseVisualStyleBackColor = true;
            // 
            // TransactionsGroup
            // 
            this.Controls.Add(this.YRG_button_AddNewAccpunt);
            this.Controls.Add(this.TRG_Button_Header_AccpuntSelect);
            this.Controls.Add(this.TRG_comboBox_Header_AccountSElector);
            this.Controls.Add(this.TRG_dataGridView);
            this.Controls.Add(this.TRG_GroupBox_SessionStats);
            this.Controls.Add(this.TRG_bAddTransact);
            this.Controls.Add(this.trabsactComment);
            this.Controls.Add(this.TransactType);
            this.Controls.Add(this.lbTransactAmount);
            this.Controls.Add(this.lbTransactDate);
            this.Controls.Add(this.TranzactGroup_tbAccountName);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbOperationType);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.btnToday);
            this.Name = "TransactionsGroup";
            this.Size = new System.Drawing.Size(1010, 615);
            this.Load += new System.EventHandler(this.TransactionsGroup_Load);
            this.TRG_GroupBox_SessionStats.ResumeLayout(false);
            this.TRG_GroupBox_SessionStats.PerformLayout();
            this.TRG_groupBox_AddBewAccount.ResumeLayout(false);
            this.TRG_groupBox_AddBewAccount.PerformLayout();
            this.TRG_GroupBox_SessionStats_TotalAmount.ResumeLayout(false);
            this.TRG_GroupBox_SessionStats_TotalAmount.PerformLayout();
            this.TRG_GroupBox_SessionStats_Transaction_QTY.ResumeLayout(false);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRG_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TranzactGroup_tbAccountName;

        private Label lbTransactDate;
        private Label lbTransactAmount;
        private Label TransactType;
        private Label trabsactComment;
        private Label TRG_Label_IncomeQTY;
        private Label TRG_SessionStats_Label_OveralTransactionsQTY;
        private Label GB_SуssionStats_label_transactions_QTY;
        private Label TRG_SessionStats_Label_transactionsQTY;
        private Label TRG_label_NewAccount_IncomeTotal;
        private Label TRG_label_NewAccount_ExpeseTotal;

        private GroupBox TRG_GroupBox_SessionStats;
        private GroupBox TRG_GroupBox_SessionStats_TotalAmount;
        private GroupBox TRG_GroupBox_SessionStats_Transaction_QTY;

        private TextBox TRG_SessionStats_RichTextBox_Overal_Balanse;
        private TextBox TRG_TextBox_NewAccountName;
        private TextBox TRG_textBox_NewAccountBalanse;
        private TextBox TRG_textBox_NewAccountDescription;


        private RichTextBox TRG_RichTextBox_ExpenseQTY;
        private RichTextBox TRG_SessionStats_RichTextBox_Overal_Income_Balanse;
        private RichTextBox TRG_SessionStats_RichTextBox_Overal_Expense_Balanse;
        private RichTextBox TRG_RichTextBox_IncomeQTY;
        private RichTextBox rtbTransact_QTY;

        private Button TRG_bAddTransact;
        private Button TRG_Button_Header_AccpuntSelect;
        private Button YRG_button_AddNewAccpunt;

        private ComboBox TRG_comboBox_Header_AccountSElector;
        private GroupBox TRG_groupBox_AddBewAccount;
        private ComboBox TRG_comboBox_NewACcountType;

        private DataGridView TRG_dataGridView;


    }
}