using Microsoft.VisualBasic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace mdTestCreator
{
    partial class AppForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox BoxTestname;
        private TextBox BoxDescription;
        private Button bStart;
        private TabControl tabs;
        private TabPage TestPage;
        private TabPage ReportPage;
        private Label mdExtendion;
        private TestRowRecord customElement;
        private TestRowRecord PreviousTestRowRecord;
        private TestRowRecord FirstTestКow;
        public static int stepsQTY = 1;
        private const int indent = 10;
        public static bool isFirst = true;
        private const string mainFormCaption = "message from main Form";

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void AddFirstSTepRow()
        {
            //MessageBox.Show("we are inside InitFirstSTepRow", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            SuspendLayout();
            FirstTestКow = new TestRowRecord();
            FirstTestКow.Location = new Point(10, 76);
            FirstTestКow.Size = new Size(700, 32);
            FirstTestКow.TabIndex = 4;
            PreviousTestRowRecord = FirstTestКow;
            Controls.Add(FirstTestКow);
            TestPage.Controls.Add(FirstTestКow);
            ResumeLayout(true);
            if (isFirst)
            {
                isFirst = false;
                stepsQTY++;
            }
            PreviousTestRowRecord.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            PreviousTestRowRecord.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;

        }

        private void InitializeComponent()
        {
            BoxTestname = new TextBox();
            BoxDescription = new TextBox();
            bStart = new Button();
            tabs = new TabControl();
            TestPage = new TabPage();
            mdExtendion = new Label();
            ReportPage = new TabPage();
            tabs.SuspendLayout();
            TestPage.SuspendLayout();
            SuspendLayout();
            // 
            // customElement
            // 
            //customElement.Location = new Point(10, 72);
            //customElement.Name = "customElement";
            //customElement.Size = new Size(762, 85);
            //customElement.TabIndex = 4;
            // 
            // BoxTestname
            // 
            BoxTestname.Location = new Point(10, 10);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.PlaceholderText = "Type here short test case name title(filename)";
            BoxTestname.Size = new Size(510, 23);
            BoxTestname.TabIndex = 0;
            // 
            // BoxDescription
            // 
            BoxDescription.Location = new Point(10, 43);
            BoxDescription.Multiline = true;
            BoxDescription.Name = "BoxDescription";
            BoxDescription.PlaceholderText = "Type here short description what this test case will do.";
            BoxDescription.Size = new Size(510, 23);
            BoxDescription.TabIndex = 1;
            // 
            // bStart
            // 
            bStart.Location = new Point(570, 10);
            bStart.Name = "bStart";
            bStart.Size = new Size(80, 23);
            bStart.TabIndex = 2;
            bStart.Text = "Let`s Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // tabs
            // 
            tabs.Controls.Add(TestPage);
            tabs.Controls.Add(ReportPage);
            tabs.Location = new Point(-4, 12);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1024, 768);
            tabs.TabIndex = 4;
            // 
            // TestPage
            // 
            TestPage.BackColor = Color.Transparent;
            TestPage.Controls.Add(customElement);
            TestPage.Controls.Add(mdExtendion);
            TestPage.Controls.Add(BoxTestname);
            TestPage.Controls.Add(BoxDescription);
            TestPage.Controls.Add(bStart);
            TestPage.Location = new Point(4, 24);
            TestPage.Name = "TestPage";
            TestPage.Padding = new Padding(3);
            TestPage.Size = new Size(1016, 740);
            TestPage.TabIndex = 0;
            TestPage.Text = "TestPage";
            TestPage.AutoScroll = true;
            // 
            // mdExtendion
            // 
            mdExtendion.AutoSize = true;
            mdExtendion.Location = new Point(530, 12);
            mdExtendion.Name = "mdExtendion";
            mdExtendion.Size = new Size(28, 15);
            mdExtendion.TabIndex = 3;
            mdExtendion.Text = ".md";
            // 
            // ReportPage
            // 
            ReportPage.Location = new Point(4, 24);
            ReportPage.Name = "ReportPage";
            ReportPage.Padding = new Padding(3);
            ReportPage.Size = new Size(1016, 740);
            ReportPage.TabIndex = 1;
            ReportPage.Text = "ReportPage";
            ReportPage.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 768);
            Controls.Add(tabs);
            Name = "AppForm";
            Text = "msTestCreator";
            tabs.ResumeLayout(false);
            TestPage.ResumeLayout(false);
            TestPage.PerformLayout();
            ResumeLayout(false);
        }

        private void Custom_AddStepButton_ButtonClicked(object sender, EventArgs e)
        {

            TestRowRecord newStepRow = new TestRowRecord();
            newStepRow.Location =  new Point(PreviousTestRowRecord.Location.X, PreviousTestRowRecord.Location.Y + PreviousTestRowRecord.Height + indent);
            newStepRow.SetRowNumber(stepsQTY);
            newStepRow.Size = new Size(700, 32);
            newStepRow.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            newStepRow.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;
            stepsQTY++;

            Controls.Add(newStepRow);
            TestPage.Controls.Add(newStepRow);
            PreviousTestRowRecord = newStepRow;

            // Scroll to bottom
            TestPage.VerticalScroll.Value = TestPage.VerticalScroll.Maximum;
            TestPage.PerformLayout();  // Ensure the layout is updated

            //            TestPage.VerticalScroll.Value = VerticalScroll.Value;
            //
            /*
             myform.Paint += (o, e) => {
                    Graphics g = e.Graphics;
                    using (Pen selPen = new Pen(Color.Blue))
                    {
                        g.DrawRectangle(selPen, 10, 10, 50, 50);
                    }
                };
             */
            // Optionally, do something when a new step is added
            //MessageBox.Show("Custom New Step Added", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //InitializeCustomComponent(stepsQTY);
            // Update PreviousTestRowRecord to point to the new control

        }
        private void Custom_CompleteButton_ButttonClicked(object sender, EventArgs e)
        {
            // Optionally, do something when a new step is added
            //MessageBox.Show("Custom Complete buttton clicked", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update PreviousTestRowRecord to point to the new control
            PreviousTestRowRecord = sender as TestRowRecord;
        }
        //private void Custom_AddStepButton_ButttonClicked(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Custom_AddStepButton_ButttonClicked", "main Application Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        private void bStart_Click(object sender, EventArgs e)
        {
            if (BoxTestname.Text == string.Empty)
            {
                MessageBox.Show("Please input short test case name.(filename)", caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show("Init First test step row", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddFirstSTepRow();
            }
        }
    }
}
