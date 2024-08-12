using mdTest.CustomElment;
namespace mdTest
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel Templatepanel;

        private TestRow testRow = new TestRow();

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

            //+= new EventHandler(UserControl_ColorChanged)

        private void addTesstRow_ButttonClicked(object sender, EventArgs e)
        {
            //enable button here
        }
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            Templatepanel = new Panel();
            FirsttestRow = new TestRow();
            tabControl1 = new TabControl();
            testPage = new TabPage();
            BoxDescsription = new TextBox();
            testRow1 = new TestRow();
            reportPage = new TabPage();
            Templatepanel.SuspendLayout();
            tabControl1.SuspendLayout();
            testPage.SuspendLayout();
            SuspendLayout();
            // 
            // Templatepanel
            // 
            Templatepanel.Controls.Add(FirsttestRow);
            Templatepanel.Location = new Point(0, 0);
            Templatepanel.Name = "Templatepanel";
            Templatepanel.Size = new Size(200, 100);
            Templatepanel.TabIndex = 0;
            // 
            // FirsttestRow
            // 
            FirsttestRow.Location = new Point(12, 12);
            FirsttestRow.Name = "FirsttestRow";
            FirsttestRow.Size = new Size(291, 23);
            FirsttestRow.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(testPage);
            tabControl1.Controls.Add(reportPage);
            tabControl1.Location = new Point(7, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 500);
            tabControl1.TabIndex = 0;
            // 
            // testPage
            // 
            testPage.Controls.Add(BoxDescsription);
            testPage.Controls.Add(testRow1);
            testPage.Location = new Point(4, 24);
            testPage.Name = "testPage";
            testPage.Padding = new Padding(3);
            testPage.Size = new Size(792, 472);
            testPage.TabIndex = 0;
            testPage.Text = "Test Writer";
            testPage.UseVisualStyleBackColor = true;
            // 
            // BoxDescsription
            // 
            BoxDescsription.BorderStyle = BorderStyle.FixedSingle;
            BoxDescsription.Location = new Point(16, 6);
            BoxDescsription.Multiline = true;
            BoxDescsription.Name = "BoxDescsription";
            BoxDescsription.Size = new Size(757, 72);
            BoxDescsription.TabIndex = 2;
            BoxDescsription.Text = resources.GetString("BoxDescsription.Text");
            // 
            // testRow1
            // 
            testRow1.Location = new Point(6, 98);
            testRow1.Name = "testRow1";
            testRow1.Size = new Size(419, 40);
            testRow1.TabIndex = 0;
            // 
            // reportPage
            // 
            reportPage.Location = new Point(4, 24);
            reportPage.Name = "reportPage";
            reportPage.Padding = new Padding(3);
            reportPage.Size = new Size(792, 472);
            reportPage.TabIndex = 1;
            reportPage.Text = "Report Writer";
            reportPage.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 511);
            Controls.Add(tabControl1);
            Name = "AppForm";
            Text = ".md Test Writer";
            Templatepanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            testPage.ResumeLayout(false);
            testPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private void Add_TestCase_step(object sender, EventArgs e)
        {

        }

        private TabControl tabControl1;
        private TabPage testPage;
        private TabPage reportPage;
        private CustomElment.TestRow testRow1;
        private TestRow FirsttestRow;
        private TextBox BoxDescsription;
    }
}
