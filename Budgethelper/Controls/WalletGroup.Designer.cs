namespace Budgethelper.Controls
{
    partial class WalletGroup
    {
        private byte _verticalShift = 50;
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
            this.WG_GroupBox_NewWalletName = new System.Windows.Forms.GroupBox();
            this.WG_Button_NewWalletName_Save = new System.Windows.Forms.Button();
            this.WF_textBox_NewWalletName = new System.Windows.Forms.TextBox();
            this.WG_GroupBox_NewWalletMoneySource = new System.Windows.Forms.GroupBox();
            this.WG_Button_newWallet_MoneySources_Save = new System.Windows.Forms.Button();
            this.WG_TextBox_NewWalletCardInitBalance = new System.Windows.Forms.TextBox();
            this.WG_TextBox_NewWalletCashInitBalance = new System.Windows.Forms.TextBox();
            this.WG_Label_NewWalletCardInitBalance = new System.Windows.Forms.Label();
            this.WG_Label_NewWalletCshInitBalance = new System.Windows.Forms.Label();
            this.WG_GroupBox_NewWalletMoneySourcess_List = new System.Windows.Forms.GroupBox();
            this.WG_Button_newWallet_Add_MoneySources = new System.Windows.Forms.Button();
            this.G_GroupBox_available_Money_Sourcess = new System.Windows.Forms.GroupBox();
            this.WG_GroupBox_NewWalletName.SuspendLayout();
            this.WG_GroupBox_NewWalletMoneySource.SuspendLayout();
            this.SuspendLayout();
            // 
            // WG_GroupBox_NewWalletName
            // 
            this.WG_GroupBox_NewWalletName.Controls.Add(this.WG_Button_NewWalletName_Save);
            this.WG_GroupBox_NewWalletName.Controls.Add(this.WF_textBox_NewWalletName);
            this.WG_GroupBox_NewWalletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WG_GroupBox_NewWalletName.Location = new System.Drawing.Point(20, 20);
            this.WG_GroupBox_NewWalletName.Name = "WG_GroupBox_NewWalletName";
            this.WG_GroupBox_NewWalletName.Size = new System.Drawing.Size(365, 50);
            this.WG_GroupBox_NewWalletName.TabIndex = 1;
            this.WG_GroupBox_NewWalletName.TabStop = false;
            this.WG_GroupBox_NewWalletName.Text = "Имя (псевдоним) Вашего нового коешлька";
            // 
            // WG_Button_NewWalletName_Save
            // 
            this.WG_Button_NewWalletName_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WG_Button_NewWalletName_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WG_Button_NewWalletName_Save.Location = new System.Drawing.Point(280, 20);
            this.WG_Button_NewWalletName_Save.Name = "WG_Button_NewWalletName_Save";
            this.WG_Button_NewWalletName_Save.Size = new System.Drawing.Size(75, 23);
            this.WG_Button_NewWalletName_Save.TabIndex = 2;
            this.WG_Button_NewWalletName_Save.Text = "Сохранить";
            this.WG_Button_NewWalletName_Save.UseVisualStyleBackColor = true;
            // 
            // WF_textBox_NewWalletName
            // 
            this.WF_textBox_NewWalletName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WF_textBox_NewWalletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WF_textBox_NewWalletName.Location = new System.Drawing.Point(10, 20);
            this.WF_textBox_NewWalletName.Name = "WF_textBox_NewWalletName";
            this.WF_textBox_NewWalletName.Size = new System.Drawing.Size(260, 20);
            this.WF_textBox_NewWalletName.TabIndex = 1;
            this.WF_textBox_NewWalletName.Text = "укажите короткое имя Вашего нового кошелька.";
            // 
            // WG_GroupBox_NewWalletMoneySource
            // 
            this.WG_GroupBox_NewWalletMoneySource.Controls.Add(this.WG_Button_newWallet_MoneySources_Save);
            this.WG_GroupBox_NewWalletMoneySource.Controls.Add(this.WG_TextBox_NewWalletCardInitBalance);
            this.WG_GroupBox_NewWalletMoneySource.Controls.Add(this.WG_TextBox_NewWalletCashInitBalance);
            this.WG_GroupBox_NewWalletMoneySource.Controls.Add(this.WG_Label_NewWalletCardInitBalance);
            this.WG_GroupBox_NewWalletMoneySource.Controls.Add(this.WG_Label_NewWalletCshInitBalance);
            this.WG_GroupBox_NewWalletMoneySource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WG_GroupBox_NewWalletMoneySource.Location = new System.Drawing.Point(20, 80);
            this.WG_GroupBox_NewWalletMoneySource.Name = "WG_GroupBox_NewWalletMoneySource";
            this.WG_GroupBox_NewWalletMoneySource.Size = new System.Drawing.Size(365, 80);
            this.WG_GroupBox_NewWalletMoneySource.TabIndex = 2;
            this.WG_GroupBox_NewWalletMoneySource.TabStop = false;
            this.WG_GroupBox_NewWalletMoneySource.Text = "Денежные средства:";
            // 
            // WG_Button_newWallet_MoneySources_Save
            // 
            this.WG_Button_newWallet_MoneySources_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WG_Button_newWallet_MoneySources_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WG_Button_newWallet_MoneySources_Save.Location = new System.Drawing.Point(280, 20);
            this.WG_Button_newWallet_MoneySources_Save.Name = "WG_Button_newWallet_MoneySources_Save";
            this.WG_Button_newWallet_MoneySources_Save.Size = new System.Drawing.Size(75, 23);
            this.WG_Button_newWallet_MoneySources_Save.TabIndex = 5;
            this.WG_Button_newWallet_MoneySources_Save.Text = "Сохранить";
            this.WG_Button_newWallet_MoneySources_Save.UseVisualStyleBackColor = true;
            // 
            // WG_TextBox_NewWalletCardInitBalance
            // 
            this.WG_TextBox_NewWalletCardInitBalance.Location = new System.Drawing.Point(98, 50);
            this.WG_TextBox_NewWalletCardInitBalance.Name = "WG_TextBox_NewWalletCardInitBalance";
            this.WG_TextBox_NewWalletCardInitBalance.Size = new System.Drawing.Size(100, 20);
            this.WG_TextBox_NewWalletCardInitBalance.TabIndex = 4;
            // 
            // WG_TextBox_NewWalletCashInitBalance
            // 
            this.WG_TextBox_NewWalletCashInitBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WG_TextBox_NewWalletCashInitBalance.Location = new System.Drawing.Point(98, 20);
            this.WG_TextBox_NewWalletCashInitBalance.Name = "WG_TextBox_NewWalletCashInitBalance";
            this.WG_TextBox_NewWalletCashInitBalance.Size = new System.Drawing.Size(100, 20);
            this.WG_TextBox_NewWalletCashInitBalance.TabIndex = 3;
            // 
            // WG_Label_NewWalletCardInitBalance
            // 
            this.WG_Label_NewWalletCardInitBalance.AutoSize = true;
            this.WG_Label_NewWalletCardInitBalance.Location = new System.Drawing.Point(20, 49);
            this.WG_Label_NewWalletCardInitBalance.Name = "WG_Label_NewWalletCardInitBalance";
            this.WG_Label_NewWalletCardInitBalance.Size = new System.Drawing.Size(62, 13);
            this.WG_Label_NewWalletCardInitBalance.TabIndex = 1;
            this.WG_Label_NewWalletCardInitBalance.Text = "Карточка";
            // 
            // WG_Label_NewWalletCshInitBalance
            // 
            this.WG_Label_NewWalletCshInitBalance.AutoSize = true;
            this.WG_Label_NewWalletCshInitBalance.Location = new System.Drawing.Point(20, 20);
            this.WG_Label_NewWalletCshInitBalance.Name = "WG_Label_NewWalletCshInitBalance";
            this.WG_Label_NewWalletCshInitBalance.Size = new System.Drawing.Size(66, 13);
            this.WG_Label_NewWalletCshInitBalance.TabIndex = 0;
            this.WG_Label_NewWalletCshInitBalance.Text = "Наличные";
            // 
            // WG_GroupBox_NewWalletMoneySourcess_List
            // 
            this.WG_GroupBox_NewWalletMoneySourcess_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WG_GroupBox_NewWalletMoneySourcess_List.Location = new System.Drawing.Point(20, 180);
            this.WG_GroupBox_NewWalletMoneySourcess_List.Name = "WG_GroupBox_NewWalletMoneySourcess_List";
            this.WG_GroupBox_NewWalletMoneySourcess_List.Size = new System.Drawing.Size(110, 100);
            this.WG_GroupBox_NewWalletMoneySourcess_List.TabIndex = 3;
            this.WG_GroupBox_NewWalletMoneySourcess_List.TabStop = false;
            this.WG_GroupBox_NewWalletMoneySourcess_List.Text = "ВАш Кошелёк:\r\n {uid}";
            // 
            // WG_Button_newWallet_Add_MoneySources
            // 
            this.WG_Button_newWallet_Add_MoneySources.Location = new System.Drawing.Point(140, 225);
            this.WG_Button_newWallet_Add_MoneySources.Name = "WG_Button_newWallet_Add_MoneySources";
            this.WG_Button_newWallet_Add_MoneySources.Size = new System.Drawing.Size(100, 23);
            this.WG_Button_newWallet_Add_MoneySources.TabIndex = 4;
            this.WG_Button_newWallet_Add_MoneySources.Text = "<= Добавить";
            this.WG_Button_newWallet_Add_MoneySources.UseVisualStyleBackColor = true;
            // 
            // G_GroupBox_available_Money_Sourcess
            // 
            this.G_GroupBox_available_Money_Sourcess.Location = new System.Drawing.Point(246, 180);
            this.G_GroupBox_available_Money_Sourcess.Name = "G_GroupBox_available_Money_Sourcess";
            this.G_GroupBox_available_Money_Sourcess.Size = new System.Drawing.Size(120, 100);
            this.G_GroupBox_available_Money_Sourcess.TabIndex = 5;
            this.G_GroupBox_available_Money_Sourcess.TabStop = false;
            this.G_GroupBox_available_Money_Sourcess.Text = "Досьупные счета:";
            // 
            // WalletGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.G_GroupBox_available_Money_Sourcess);
            this.Controls.Add(this.WG_Button_newWallet_Add_MoneySources);
            this.Controls.Add(this.WG_GroupBox_NewWalletMoneySourcess_List);
            this.Controls.Add(this.WG_GroupBox_NewWalletMoneySource);
            this.Controls.Add(this.WG_GroupBox_NewWalletName);
            this.Name = "WalletGroup";
            this.Size = new System.Drawing.Size(405, 300);
            this.WG_GroupBox_NewWalletName.ResumeLayout(false);
            this.WG_GroupBox_NewWalletName.PerformLayout();
            this.WG_GroupBox_NewWalletMoneySource.ResumeLayout(false);
            this.WG_GroupBox_NewWalletMoneySource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WG_GroupBox_NewWalletName;
        private System.Windows.Forms.GroupBox WG_GroupBox_NewWalletMoneySource;
        private System.Windows.Forms.GroupBox WG_GroupBox_NewWalletMoneySourcess_List;
        private System.Windows.Forms.GroupBox G_GroupBox_available_Money_Sourcess;

        private System.Windows.Forms.TextBox WF_textBox_NewWalletName;
        private System.Windows.Forms.TextBox WG_TextBox_NewWalletCardInitBalance;
        private System.Windows.Forms.TextBox WG_TextBox_NewWalletCashInitBalance;
        
        private System.Windows.Forms.Button WG_Button_NewWalletName_Save;
        private System.Windows.Forms.Button WG_Button_newWallet_MoneySources_Save;
        private System.Windows.Forms.Button WG_Button_newWallet_Add_MoneySources;

        private System.Windows.Forms.Label WG_Label_NewWalletCardInitBalance;
        private System.Windows.Forms.Label WG_Label_NewWalletCshInitBalance;
    }
}
