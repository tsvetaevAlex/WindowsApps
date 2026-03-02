using System;
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
            this.rtbTransact_QTY = new System.Windows.Forms.RichTextBox();
            this.labelSessionStats = new System.Windows.Forms.Label();
            this.bAddTransact = new System.Windows.Forms.Button();
            this.GB_Stats = new System.Windows.Forms.GroupBox();
            this.dgvSessionStats = new System.Windows.Forms.DataGridView();
            this.rtbTransactStats = new System.Windows.Forms.RichTextBox();
            this.tbTransactQTY = new System.Windows.Forms.TextBox();
            this.GB_Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionStats)).BeginInit();
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
            this.datePicker.TabIndex = 1;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(240, 55);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(100, 20);
            this.tbAmount.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(460, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // cbOperationType
            // 
            this.cbOperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Location = new System.Drawing.Point(350, 55);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(100, 21);
            this.cbOperationType.TabIndex = 4;
            // 
            // btnYesterday
            // 
            this.btnYesterday.Location = new System.Drawing.Point(110, 80);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(60, 23);
            this.btnYesterday.TabIndex = 5;
            this.btnYesterday.Text = "Вчера";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.BtnYesterday_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(170, 80);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(60, 23);
            this.btnToday.TabIndex = 6;
            this.btnToday.Text = "Сегодня";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.BtnToday_Click);
            // 
            // TranzactGroup_tbAccountName
            // 
            this.TranzactGroup_tbAccountName.Location = new System.Drawing.Point(20, 55);
            this.TranzactGroup_tbAccountName.Name = "TranzactGroup_tbAccountName";
            this.TranzactGroup_tbAccountName.Size = new System.Drawing.Size(80, 20);
            this.TranzactGroup_tbAccountName.TabIndex = 8;
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
            // rtbTransact_QTY
            // 
            this.rtbTransact_QTY.BackColor = System.Drawing.Color.Black;
            this.rtbTransact_QTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTransact_QTY.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rtbTransact_QTY.Location = new System.Drawing.Point(20, 70);
            this.rtbTransact_QTY.Margin = new System.Windows.Forms.Padding(5);
            this.rtbTransact_QTY.Name = "rtbTransact_QTY";
            this.rtbTransact_QTY.ReadOnly = true;
            this.rtbTransact_QTY.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTransact_QTY.Size = new System.Drawing.Size(180, 70);
            this.rtbTransact_QTY.TabIndex = 24;
            this.rtbTransact_QTY.TabStop = false;
            this.rtbTransact_QTY.Text = "";
            // 
            // labelSessionStats
            // 
            this.labelSessionStats.AutoSize = true;
            this.labelSessionStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSessionStats.Location = new System.Drawing.Point(210, 47);
            this.labelSessionStats.Name = "labelSessionStats";
            this.labelSessionStats.Size = new System.Drawing.Size(181, 13);
            this.labelSessionStats.TabIndex = 17;
            this.labelSessionStats.Text = "Транзакции за текущую Сессиию:";
            // 
            // bAddTransact
            // 
            this.bAddTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddTransact.Location = new System.Drawing.Point(615, 55);
            this.bAddTransact.Name = "bAddTransact";
            this.bAddTransact.Size = new System.Drawing.Size(96, 48);
            this.bAddTransact.TabIndex = 18;
            this.bAddTransact.Text = "Добавить Транзакцию";
            this.bAddTransact.UseVisualStyleBackColor = true;
            this.bAddTransact.Click += new System.EventHandler(this.bAddTransact_Click);
            // 
            // GB_Stats
            // 
            this.GB_Stats.Controls.Add(this.dgvSessionStats);
            this.GB_Stats.Controls.Add(this.rtbTransactStats);
            this.GB_Stats.Controls.Add(this.tbTransactQTY);
            this.GB_Stats.Controls.Add(this.rtbTransact_QTY);
            this.GB_Stats.Controls.Add(this.labelSessionStats);
            this.GB_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.GB_Stats.Location = new System.Drawing.Point(20, 110);
            this.GB_Stats.Name = "GB_Stats";
            this.GB_Stats.Size = new System.Drawing.Size(760, 550);
            this.GB_Stats.TabIndex = 19;
            this.GB_Stats.TabStop = false;
            this.GB_Stats.Text = "Краткая Ствтистика Сессии:";
            // dgvSessionStats
            this.dgvSessionStats.AllowUserToAddRows = false;
            this.dgvSessionStats.AllowUserToDeleteRows = false;
            this.dgvSessionStats.AllowUserToResizeRows = false;
            this.dgvSessionStats.MultiSelect = false;
            this.dgvSessionStats.ReadOnly = true;
            this.dgvSessionStats.RowHeadersVisible = false;
            this.dgvSessionStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dgvSessionStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessionStats.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            this.dgvSessionStats.BackgroundColor = Color.White;
            this.dgvSessionStats.BorderStyle = BorderStyle.FixedSingle;
            this.dgvSessionStats.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSessionStats.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            this.dgvSessionStats.EnableHeadersVisualStyles = false;
            this.dgvSessionStats.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;
            this.dgvSessionStats.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgvSessionStats.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSessionStats.ColumnHeadersHeight = 28;

            this.dgvSessionStats.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            this.dgvSessionStats.DefaultCellStyle.SelectionForeColor = Color.Black;

            this.dgvSessionStats.Location = new System.Drawing.Point(20, 150);
            this.dgvSessionStats.Name = "dgvSessionStats";
            this.dgvSessionStats.Size = new System.Drawing.Size(730, 390);
            this.dgvSessionStats.TabIndex = 0;
            this.dgvSessionStats.TabStop = false;
            // 
            // rtbTransactStats
            // 
            this.rtbTransactStats.BackColor = System.Drawing.Color.Black;
            this.rtbTransactStats.ForeColor = System.Drawing.Color.Snow;
            this.rtbTransactStats.Location = new System.Drawing.Point(210, 70);
            this.rtbTransactStats.Name = "rtbTransactStats";
            this.rtbTransactStats.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTransactStats.Size = new System.Drawing.Size(540, 70);
            this.rtbTransactStats.TabIndex = 23;
            this.rtbTransactStats.TabStop = false;
            this.rtbTransactStats.Text = "";
            // 
            // tbTransactQTY
            // 
            this.tbTransactQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbTransactQTY.Location = new System.Drawing.Point(20, 20);
            this.tbTransactQTY.Multiline = true;
            this.tbTransactQTY.Name = "tbTransactQTY";
            this.tbTransactQTY.ReadOnly = true;
            this.tbTransactQTY.Size = new System.Drawing.Size(140, 40);
            this.tbTransactQTY.TabIndex = 19;
            this.tbTransactQTY.Text = "количество транзакций\r\nза текущую сессию:";
            this.tbTransactQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TransactionsGroup
            // 
            this.Controls.Add(this.GB_Stats);
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
            this.Size = new System.Drawing.Size(800, 680);
            this.GB_Stats.ResumeLayout(false);
            this.GB_Stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TranzactGroup_tbAccountName;
        private System.Windows.Forms.Label lbTransactDate;
        private System.Windows.Forms.Label lbTransactAmount;
        private System.Windows.Forms.Label TransactType;
        private System.Windows.Forms.Label trabsactComment;
        private System.Windows.Forms.RichTextBox rtbTransact_QTY;
        private System.Windows.Forms.Label labelSessionStats;
        private System.Windows.Forms.Button bAddTransact;
        private System.Windows.Forms.GroupBox GB_Stats;
        private System.Windows.Forms.TextBox tbTransactQTY;
        private System.Windows.Forms.RichTextBox rtbTransactStats;
        private DataGridView dgvSessionStats;
    }
}