using System.Windows.Forms;

namespace BudgethelperGUI.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private RichTextBox rtbFooter;

        private void InitializeComponent()
        {
            this.rtbFooter = new RichTextBox();
            this.SuspendLayout();

            // rtbFooter
            this.rtbFooter.BackColor = System.Drawing.Color.Black;
            this.rtbFooter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtbFooter.Dock = DockStyle.Bottom;
            this.rtbFooter.Height = 24;
            this.rtbFooter.ReadOnly = true;
            this.rtbFooter.BorderStyle = BorderStyle.FixedSingle;

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbFooter);
            this.Text = "BudgetHelper v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }
    }
}
