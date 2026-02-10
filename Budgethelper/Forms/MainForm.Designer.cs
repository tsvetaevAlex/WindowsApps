using System.Windows.Forms;

namespace Budgethelper.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Budgethelper.Controls.AccountsGroup accountsGroup;
        private Budgethelper.Controls.TransactionsGroup transactionsGroup;
        private RichTextBox rtbStatusBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.accountsGroup = new Budgethelper.Controls.AccountsGroup();
            this.transactionsGroup = new Budgethelper.Controls.TransactionsGroup();
            this.rtbStatusBar = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // accountsGroup
            // 
            this.accountsGroup.Location = new System.Drawing.Point(20, 20);
            this.accountsGroup.Name = "accountsGroup";
            this.accountsGroup.Size = new System.Drawing.Size(960, 200);
            this.accountsGroup.TabIndex = 0;
            // 
            // transactionsGroup
            // 
            this.transactionsGroup.Location = new System.Drawing.Point(20, 240);
            this.transactionsGroup.Name = "transactionsGroup";
            this.transactionsGroup.Size = new System.Drawing.Size(960, 370);
            this.transactionsGroup.TabIndex = 1;
            // 
            // rtbStatusBar
            // 
            this.rtbStatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.rtbStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbStatusBar.Font = new System.Drawing.Font("Consolas", 12F);
            this.rtbStatusBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbStatusBar.Location = new System.Drawing.Point(0, 689);
            this.rtbStatusBar.Name = "rtbStatusBar";
            this.rtbStatusBar.ReadOnly = true;
            this.rtbStatusBar.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbStatusBar.Size = new System.Drawing.Size(1008, 40);
            this.rtbStatusBar.TabIndex = 2;
            this.rtbStatusBar.TabStop = false;
            this.rtbStatusBar.Text = "";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.accountsGroup);
            this.Controls.Add(this.transactionsGroup);
            this.Controls.Add(this.rtbStatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetHelper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
    }
}
