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

            // -------------------------------------------------
            // MainForm (фиксированный размер)
            // -------------------------------------------------
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "BudgetHelper";
            this.Load += new System.EventHandler(this.MainForm_Load);

            // -------------------------------------------------
            // accountsGroup
            // -------------------------------------------------
            this.accountsGroup.Location = new System.Drawing.Point(20, 20);
            this.accountsGroup.Size = new System.Drawing.Size(960, 200);

            // -------------------------------------------------
            // transactionsGroup
            // -------------------------------------------------
            this.transactionsGroup.Location = new System.Drawing.Point(20, 240);
            this.transactionsGroup.Size = new System.Drawing.Size(960, 370);

            // -------------------------------------------------
            // rtbStatusBar
            // -------------------------------------------------
            this.rtbStatusBar.Dock = DockStyle.Bottom;
            this.rtbStatusBar.Height = 40;
            this.rtbStatusBar.ReadOnly = true;
            this.rtbStatusBar.BorderStyle = BorderStyle.FixedSingle;
            this.rtbStatusBar.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            this.rtbStatusBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbStatusBar.ScrollBars = RichTextBoxScrollBars.None;
            this.rtbStatusBar.TabStop = false;
            this.rtbStatusBar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular);

            // -------------------------------------------------
            // Add Controls
            // -------------------------------------------------
            this.Controls.Add(this.accountsGroup);
            this.Controls.Add(this.transactionsGroup);
            this.Controls.Add(this.rtbStatusBar);

            this.ResumeLayout(false);
        }
    }
}
