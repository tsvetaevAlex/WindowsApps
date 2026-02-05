using System;

namespace Budgethelper.Controls
{
    partial class TransactionsGroup
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.DataGridView grid;

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
            this.components = new System.ComponentModel.Container();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbTransactDate = new System.Windows.Forms.Label();
            this.lbTransactAmount = new System.Windows.Forms.Label();
            this.TransactType = new System.Windows.Forms.Label();
            this.trabsactComment = new System.Windows.Forms.Label();
            this.rtbTransact_QTY = new System.Windows.Forms.RichTextBox();
            this.rtbTransact_Stats = new System.Windows.Forms.RichTextBox();
            this.rtbSessionStats = new System.Windows.Forms.Label();
            this.bAddTransact = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTransactQTY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(240, 55);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(460, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(350, 55);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(100, 21);
            this.comboType.TabIndex = 4;
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
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.Location = new System.Drawing.Point(10, 110);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(500, 340);
            this.grid.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.rtbTransact_QTY.Location = new System.Drawing.Point(8, 92);
            this.rtbTransact_QTY.Margin = new System.Windows.Forms.Padding(5);
            this.rtbTransact_QTY.Name = "rtbTransact_QTY";
            this.rtbTransact_QTY.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbTransact_QTY.Size = new System.Drawing.Size(183, 64);
            this.rtbTransact_QTY.TabIndex = 14;
            this.rtbTransact_QTY.Text = "123456";
            // 
            // rtbTransact_Stats
            // 
            this.rtbTransact_Stats.BackColor = System.Drawing.Color.Black;
            this.rtbTransact_Stats.Location = new System.Drawing.Point(10, 205);
            this.rtbTransact_Stats.Name = "rtbTransact_Stats";
            this.rtbTransact_Stats.Size = new System.Drawing.Size(250, 96);
            this.rtbTransact_Stats.TabIndex = 15;
            this.rtbTransact_Stats.Text = "";
            // 
            // rtbSessionStats
            // 
            this.rtbSessionStats.AutoSize = true;
            this.rtbSessionStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rtbSessionStats.Location = new System.Drawing.Point(10, 189);
            this.rtbSessionStats.Name = "rtbSessionStats";
            this.rtbSessionStats.Size = new System.Drawing.Size(181, 13);
            this.rtbSessionStats.TabIndex = 17;
            this.rtbSessionStats.Text = "Транзакции за текущую Сессиию:";
            // 
            // bAddTransact
            // 
            this.bAddTransact.Location = new System.Drawing.Point(615, 55);
            this.bAddTransact.Name = "bAddTransact";
            this.bAddTransact.Size = new System.Drawing.Size(140, 21);
            this.bAddTransact.TabIndex = 18;
            this.bAddTransact.Text = "Добавить Транзакцию";
            this.bAddTransact.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTransactQTY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtbTransact_QTY);
            this.groupBox1.Controls.Add(this.rtbTransact_Stats);
            this.groupBox1.Controls.Add(this.rtbSessionStats);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(520, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 340);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Краткая Ствтистика Сессии:";
            // 
            // tbTransactQTY
            // 
            this.tbTransactQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbTransactQTY.Location = new System.Drawing.Point(6, 44);
            this.tbTransactQTY.Multiline = true;
            this.tbTransactQTY.Name = "tbTransactQTY";
            this.tbTransactQTY.ReadOnly = true;
            this.tbTransactQTY.Size = new System.Drawing.Size(140, 40);
            this.tbTransactQTY.TabIndex = 19;
            this.tbTransactQTY.Text = "количество транзакций\r\nза текущую сессию:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            // 
            // TransactionsGroup
            // 
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAddTransact);
            this.Controls.Add(this.trabsactComment);
            this.Controls.Add(this.TransactType);
            this.Controls.Add(this.lbTransactAmount);
            this.Controls.Add(this.lbTransactDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.grid);
            this.Name = "TransactionsGroup";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbTransactDate;
        private System.Windows.Forms.Label lbTransactAmount;
        private System.Windows.Forms.Label TransactType;
        private System.Windows.Forms.Label trabsactComment;
        private System.Windows.Forms.RichTextBox rtbTransact_QTY;
        private System.Windows.Forms.RichTextBox rtbTransact_Stats;
        private System.Windows.Forms.Label rtbSessionStats;
        private System.Windows.Forms.Button bAddTransact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTransactQTY;
        private System.Windows.Forms.Label label1;
    }
}
