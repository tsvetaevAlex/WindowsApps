namespace mdTest
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            testPage = new TabPage();
            reportPage = new TabPage();
            testRow1 = new CustomElment.TestRow();
            tabControl1.SuspendLayout();
            testPage.SuspendLayout();
            SuspendLayout();
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
            testPage.Controls.Add(testRow1);
            testPage.Location = new Point(4, 24);
            testPage.Name = "testPage";
            testPage.Padding = new Padding(3);
            testPage.Size = new Size(792, 472);
            testPage.TabIndex = 0;
            testPage.Text = "Test Writer";
            testPage.UseVisualStyleBackColor = true;
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
            // testRow1
            // 
            testRow1.Location = new Point(13, 20);
            testRow1.Name = "testRow1";
            testRow1.Size = new Size(419, 40);
            testRow1.TabIndex = 0;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 511);
            Controls.Add(tabControl1);
            Name = "AppForm";
            Text = ".md Test Writer";
            tabControl1.ResumeLayout(false);
            testPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage testPage;
        private TabPage reportPage;
        private CustomElment.TestRow testRow1;
    }
}
