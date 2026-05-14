namespace Budgethelper.Controls
{
    partial class NewAccountGroup
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NAG_label_title = new System.Windows.Forms.Label();
            this.NAG_textBox_AccountName = new System.Windows.Forms.TextBox();
            this.NAG_comboBox_AccountType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NAG_label_title
            // 
            this.NAG_label_title.AutoSize = true;
            this.NAG_label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAG_label_title.Location = new System.Drawing.Point(20, 20);
            this.NAG_label_title.Name = "NAG_label_title";
            this.NAG_label_title.Size = new System.Drawing.Size(526, 15);
            this.NAG_label_title.TabIndex = 0;
            this.NAG_label_title.Text = "пожалуйста введите имя дял Вашего нового источника денежныыыый средств (аккаунт)";
            // 
            // NAG_textBox_AccountName
            // 
            this.NAG_textBox_AccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NAG_textBox_AccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.NAG_textBox_AccountName.Location = new System.Drawing.Point(20, 45);
            this.NAG_textBox_AccountName.Name = "NAG_textBox_AccountName";
            this.NAG_textBox_AccountName.Size = new System.Drawing.Size(100, 20);
            this.NAG_textBox_AccountName.TabIndex = 1;
            this.NAG_textBox_AccountName.Text = "Имя аккаунта";
            this.NAG_textBox_AccountName.TextChanged += new System.EventHandler(this.NAG_textBox_AccountName_TextChanged);
            this.NAG_textBox_AccountName.MouseEnter += new System.EventHandler(this.NAG_textBox_AccountName_MouseEnter);
            // 
            // NAG_comboBox_AccountType
            // 
            this.NAG_comboBox_AccountType.FormattingEnabled = true;
            this.NAG_comboBox_AccountType.Location = new System.Drawing.Point(130, 45);
            this.NAG_comboBox_AccountType.Name = "NAG_comboBox_AccountType";
            this.NAG_comboBox_AccountType.Size = new System.Drawing.Size(100, 21);
            this.NAG_comboBox_AccountType.TabIndex = 2;
            // 
            // NewAccountGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NAG_comboBox_AccountType);
            this.Controls.Add(this.NAG_textBox_AccountName);
            this.Controls.Add(this.NAG_label_title);
            this.Name = "NewAccountGroup";
            this.Size = new System.Drawing.Size(640, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NAG_label_title;
        private System.Windows.Forms.TextBox NAG_textBox_AccountName;
        private System.Windows.Forms.ComboBox NAG_comboBox_AccountType;
    }
}
