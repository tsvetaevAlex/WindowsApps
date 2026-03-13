﻿using System;
using System.Drawing;
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
            this.bAddTransact = new System.Windows.Forms.Button();
            this.TRG_GroupBox_SessionStats = new System.Windows.Forms.GroupBox();
            this.TRG_SessionStats_RichTextBox_Overal_Balanse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TRG_GroupBox_SessionStats_TotalAmount = new System.Windows.Forms.GroupBox();
            this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse = new System.Windows.Forms.RichTextBox();
            this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse = new System.Windows.Forms.RichTextBox();
            this.GB_SуssionStats_label_Expense_totalAmount = new System.Windows.Forms.Label();
            this.GB_SуssionStats_label_INcome_TotalAmount = new System.Windows.Forms.Label();
            this.TRG_GroupBox_SessionStats_Transaction_QTY = new System.Windows.Forms.GroupBox();
            this.rtb_ExpenseQTY = new System.Windows.Forms.RichTextBox();
            this.rtb_IncomeQTY = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GB_SуssionStats_label_transactions_QTY = new System.Windows.Forms.Label();
            this.TRG_SessionStats_Label_transactionsQTY = new System.Windows.Forms.Label();
            this.rtbTransact_QTY = new System.Windows.Forms.RichTextBox();
            this.TRG_dataGridView = new System.Windows.Forms.DataGridView();
            this.TRG_GroupBox_SessionStats.SuspendLayout();
            this.TRG_GroupBox_SessionStats_TotalAmount.SuspendLayout();
            this.TRG_GroupBox_SessionStats_Transaction_QTY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRG_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(20, 35);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(78, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(110, 55);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 20);
            this.datePicker.TabIndex = 2;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(240, 55);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(460, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // cbOperationType
            // 
            this.cbOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Location = new System.Drawing.Point(350, 55);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(100, 21);
            this.cbOperationType.TabIndex = 7;
            // 
            // btnYesterday
            // 
            this.btnYesterday.Location = new System.Drawing.Point(110, 80);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(60, 25);
            this.btnYesterday.TabIndex = 4;
            this.btnYesterday.Text = "Вчера";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.BtnYesterday_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(170, 80);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(60, 25);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Сегодня";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // TranzactGroup_tbAccountName
            // 
            this.TranzactGroup_tbAccountName.Location = new System.Drawing.Point(20, 55);
            this.TranzactGroup_tbAccountName.Name = "TranzactGroup_tbAccountName";
            this.TranzactGroup_tbAccountName.Size = new System.Drawing.Size(80, 20);
            this.TranzactGroup_tbAccountName.TabIndex = 1;
            // 
            // lbTransactDate
            // 
            this.lbTransactDate.AutoSize = true;
            this.lbTransactDate.Location = new System.Drawing.Point(120, 35);
            this.lbTransactDate.Name = "lbTransactDate";
            this.lbTransactDate.Size = new System.Drawing.Size(83, 13);
            this.lbTransactDate.TabIndex = 10;
            this.lbTransactDate.Text = "transaction date";
            // 
            // lbTransactAmount
            // 
            this.lbTransactAmount.Location = new System.Drawing.Point(240, 35);
            this.lbTransactAmount.Name = "lbTransactAmount";
            this.lbTransactAmount.Size = new System.Drawing.Size(100, 13);
            this.lbTransactAmount.TabIndex = 11;
            this.lbTransactAmount.Text = "transaction amount";
            // 
            // TransactType
            // 
            this.TransactType.AutoSize = true;
            this.TransactType.Location = new System.Drawing.Point(350, 35);
            this.TransactType.Name = "TransactType";
            this.TransactType.Size = new System.Drawing.Size(89, 13);
            this.TransactType.TabIndex = 12;
            this.TransactType.Text = "income | expense";
            // 
            // trabsactComment
            // 
            this.trabsactComment.AutoSize = true;
            this.trabsactComment.Location = new System.Drawing.Point(460, 35);
            this.trabsactComment.Name = "trabsactComment";
            this.trabsactComment.Size = new System.Drawing.Size(105, 13);
            this.trabsactComment.TabIndex = 13;
            this.trabsactComment.Text = "transaction comment";
            // 
            // bAddTransact
            // 
            this.bAddTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddTransact.Location = new System.Drawing.Point(615, 55);
            this.bAddTransact.Name = "bAddTransact";
            this.bAddTransact.Size = new System.Drawing.Size(96, 48);
            this.bAddTransact.TabIndex = 9;
            this.bAddTransact.Text = "Добавить Транзакцию";
            this.bAddTransact.UseVisualStyleBackColor = true;
            this.bAddTransact.Click += new System.EventHandler(this.bAddTransact_Click);
            // 
            // TRG_GroupBox_SessionStats
            // 
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_SessionStats_RichTextBox_Overal_Balanse);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.label1);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_GroupBox_SessionStats_TotalAmount);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_GroupBox_SessionStats_Transaction_QTY);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.TRG_SessionStats_Label_transactionsQTY);
            this.TRG_GroupBox_SessionStats.Controls.Add(this.rtbTransact_QTY);
            this.TRG_GroupBox_SessionStats.Location = new System.Drawing.Point(600, 109);
            this.TRG_GroupBox_SessionStats.Name = "TRG_GroupBox_SessionStats";
            this.TRG_GroupBox_SessionStats.Size = new System.Drawing.Size(400, 495);
            this.TRG_GroupBox_SessionStats.TabIndex = 19;
            this.TRG_GroupBox_SessionStats.TabStop = false;
            this.TRG_GroupBox_SessionStats.Text = "Краткая сводка Текущей Сессии";
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Общая сумма \r\n транзакций:";
            // 
            // TRG_GroupBox_SessionStats_TotalAmount
            // 
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.TRG_SessionStats_RichTextBox_Overal_Income_Balanse);
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.TRG_SessionStats_RichTextBox_Overal_Expense_Balanse);
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.GB_SуssionStats_label_Expense_totalAmount);
            this.TRG_GroupBox_SessionStats_TotalAmount.Controls.Add(this.GB_SуssionStats_label_INcome_TotalAmount);
            this.TRG_GroupBox_SessionStats_TotalAmount.Location = new System.Drawing.Point(220, 125);
            this.TRG_GroupBox_SessionStats_TotalAmount.Name = "TRG_GroupBox_SessionStats_TotalAmount";
            this.TRG_GroupBox_SessionStats_TotalAmount.Size = new System.Drawing.Size(170, 155);
            this.TRG_GroupBox_SessionStats_TotalAmount.TabIndex = 35;
            this.TRG_GroupBox_SessionStats_TotalAmount.TabStop = false;
            this.TRG_GroupBox_SessionStats_TotalAmount.Text = "Общая сумма";
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
            // GB_SуssionStats_label_Expense_totalAmount
            // 
            this.GB_SуssionStats_label_Expense_totalAmount.AutoSize = true;
            this.GB_SуssionStats_label_Expense_totalAmount.Location = new System.Drawing.Point(20, 20);
            this.GB_SуssionStats_label_Expense_totalAmount.Name = "GB_SуssionStats_label_Expense_totalAmount";
            this.GB_SуssionStats_label_Expense_totalAmount.Size = new System.Drawing.Size(129, 13);
            this.GB_SуssionStats_label_Expense_totalAmount.TabIndex = 1;
            this.GB_SуssionStats_label_Expense_totalAmount.Text = "Общая Сумма Доходов:";
            // 
            // GB_SуssionStats_label_INcome_TotalAmount
            // 
            this.GB_SуssionStats_label_INcome_TotalAmount.AutoSize = true;
            this.GB_SуssionStats_label_INcome_TotalAmount.Location = new System.Drawing.Point(20, 97);
            this.GB_SуssionStats_label_INcome_TotalAmount.Name = "GB_SуssionStats_label_INcome_TotalAmount";
            this.GB_SуssionStats_label_INcome_TotalAmount.Size = new System.Drawing.Size(133, 13);
            this.GB_SуssionStats_label_INcome_TotalAmount.TabIndex = 0;
            this.GB_SуssionStats_label_INcome_TotalAmount.Text = "Общая Сумма Расходов:";
            // 
            // TRG_GroupBox_SessionStats_Transaction_QTY
            // 
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.rtb_ExpenseQTY);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.rtb_IncomeQTY);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.label2);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Controls.Add(this.GB_SуssionStats_label_transactions_QTY);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Location = new System.Drawing.Point(20, 125);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Name = "TRG_GroupBox_SessionStats_Transaction_QTY";
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Size = new System.Drawing.Size(190, 155);
            this.TRG_GroupBox_SessionStats_Transaction_QTY.TabIndex = 34;
            this.TRG_GroupBox_SessionStats_Transaction_QTY.TabStop = false;
            this.TRG_GroupBox_SessionStats_Transaction_QTY.Text = "Количество транзакций";
            // 
            // rtb_ExpenseQTY
            // 
            this.rtb_ExpenseQTY.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.rtb_ExpenseQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_ExpenseQTY.ForeColor = System.Drawing.Color.GhostWhite;
            this.rtb_ExpenseQTY.Location = new System.Drawing.Point(20, 45);
            this.rtb_ExpenseQTY.Name = "rtb_ExpenseQTY";
            this.rtb_ExpenseQTY.ReadOnly = true;
            this.rtb_ExpenseQTY.Size = new System.Drawing.Size(100, 25);
            this.rtb_ExpenseQTY.TabIndex = 5;
            this.rtb_ExpenseQTY.TabStop = false;
            this.rtb_ExpenseQTY.Text = "95";
            // 
            // rtb_IncomeQTY
            // 
            this.rtb_IncomeQTY.BackColor = System.Drawing.Color.Salmon;
            this.rtb_IncomeQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_IncomeQTY.ForeColor = System.Drawing.Color.GhostWhite;
            this.rtb_IncomeQTY.Location = new System.Drawing.Point(20, 120);
            this.rtb_IncomeQTY.Name = "rtb_IncomeQTY";
            this.rtb_IncomeQTY.Size = new System.Drawing.Size(100, 25);
            this.rtb_IncomeQTY.TabIndex = 4;
            this.rtb_IncomeQTY.TabStop = false;
            this.rtb_IncomeQTY.Text = "123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Income количество транзакций";
            // 
            // GB_SуssionStats_label_transactions_QTY
            // 
            this.GB_SуssionStats_label_transactions_QTY.AutoSize = true;
            this.GB_SуssionStats_label_transactions_QTY.Location = new System.Drawing.Point(20, 80);
            this.GB_SуssionStats_label_transactions_QTY.Name = "GB_SуssionStats_label_transactions_QTY";
            this.GB_SуssionStats_label_transactions_QTY.Size = new System.Drawing.Size(127, 26);
            this.GB_SуssionStats_label_transactions_QTY.TabIndex = 0;
            this.GB_SуssionStats_label_transactions_QTY.Text = "количество транзакций\r\n расхода";
            // 
            // TRG_SessionStats_Label_transactionsQTY
            // 
            this.TRG_SessionStats_Label_transactionsQTY.AutoSize = true;
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
            this.rtbTransact_QTY.Margin = new System.Windows.Forms.Padding(5);
            this.rtbTransact_QTY.Name = "rtbTransact_QTY";
            this.rtbTransact_QTY.ReadOnly = true;
            this.rtbTransact_QTY.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTransact_QTY.Size = new System.Drawing.Size(180, 50);
            this.rtbTransact_QTY.TabIndex = 25;
            this.rtbTransact_QTY.TabStop = false;
            this.rtbTransact_QTY.Text = "12345";
            // 
            // TRG_dataGridView
            // 
            this.TRG_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TRG_dataGridView.Location = new System.Drawing.Point(20, 115);
            this.TRG_dataGridView.Name = "TRG_dataGridView";
            this.TRG_dataGridView.Size = new System.Drawing.Size(550, 633);
            this.TRG_dataGridView.TabIndex = 20;
            // 
            // TransactionsGroup
            // 
            this.Controls.Add(this.TRG_dataGridView);
            this.Controls.Add(this.TRG_GroupBox_SessionStats);
            this.Controls.Add(this.bAddTransact);
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
            this.Size = new System.Drawing.Size(1010, 768);
            this.Load += new System.EventHandler(this.TransactionsGroup_Load);
            this.TRG_GroupBox_SessionStats.ResumeLayout(false);
            this.TRG_GroupBox_SessionStats.PerformLayout();
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
        private Label GB_SуssionStats_label_Expense_totalAmount;
        private Label GB_SуssionStats_label_INcome_TotalAmount;
        private Label label2;
        private Label label1;

        private System.Windows.Forms.Button bAddTransact;
        private GroupBox TRG_GroupBox_SessionStats;
        private RichTextBox rtbTransact_QTY;
        private Label TRG_SessionStats_Label_transactionsQTY;
        private GroupBox TRG_GroupBox_SessionStats_TotalAmount;
        private GroupBox TRG_GroupBox_SessionStats_Transaction_QTY;
        private Label GB_SуssionStats_label_transactions_QTY;
        private TextBox TRG_SessionStats_RichTextBox_Overal_Balanse;
        
        private RichTextBox rtb_IncomeQTY;
        private RichTextBox TRG_SessionStats_RichTextBox_Overal_Income_Balanse;
        private RichTextBox TRG_SessionStats_RichTextBox_Overal_Expense_Balanse;
        private RichTextBox rtb_ExpenseQTY;
        
        private DataGridView TRG_dataGridView;
    }
}