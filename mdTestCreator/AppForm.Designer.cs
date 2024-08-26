using Microsoft.VisualBasic;

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
            MessageBox.Show("we are inside InitFirstSTepRow", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            SuspendLayout();
            FirstTestКow = new TestRowRecord();
            FirstTestКow.Location = new Point(0, 76);
            FirstTestКow.Size = new Size(762, 41);
            FirstTestКow.TabIndex = 4;
            PreviousTestRowRecord = FirstTestКow;
            Controls.Add(FirstTestКow);
            TestPage.Controls.Add(FirstTestКow);
            ResumeLayout(true);
            if (isFirst)
            {
                isFirst = false;
            }

            stepsQTY++;
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
            //customElement.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            //customElement.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;
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

        private void InitializeCustomComponent(int stepNumber)
        {
            var newTestRow = new TestRowRecord();
            var prevRow = PreviousTestRowRecord;
            // Calculate position based on the current step number

            int pointY = isFirst ? 66 : prevRow.Location.Y + prevRow.Height + 10;
            newTestRow.Location = new Point(0, pointY);
            newTestRow.Size = new Size(762, 41);
            newTestRow.TabIndex = stepsQTY;

            // Subscribe to events
            newTestRow.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            newTestRow.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;

            // Add the new control to the TestPage
            TestPage.Controls.Add(newTestRow);

            // Increment step count
            stepsQTY++;
        }
        private void InitializeFirstCustomComponent(int number)
        {
            int Yposition = PreviousTestRowRecord.Location.Y + PreviousTestRowRecord.Height + 10;
            customElement = new TestRowRecord();
            customElement.Location = new Point(0, 66);
            customElement.Size = new Size(762, 41);
            customElement.TabIndex = 4;
            Controls.Add(customElement);

            if (isFirst)
            {
                Yposition = 66;
                FirstTestКow = new TestRowRecord();;
                PreviousTestRowRecord = customElement;
            }
            else
            {
                PreviousTestRowRecord = customElement;
            }
            //int Y = number * 66; //2 textbox 23 each + 10 between boxes and 10 bekow;
            customElement.Location = new Point(0, (customElement.Height*number + 10));
            customElement.Size = new Size(762, 41);
            customElement.TabIndex = 4;
            Controls.Add(customElement);
            PerformLayout();
        }

        private void Custom_AddStepButton_ButtonClicked(object sender, EventArgs e)
        {

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
            InitializeCustomComponent(stepsQTY);
            // Update PreviousTestRowRecord to point to the new control

        }
        private void Custom_CompleteButton_ButttonClicked(object sender, EventArgs e)
        {
            // Optionally, do something when a new step is added
            MessageBox.Show("VUstom Complete buttton clicked", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Init First test step row", caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                AddFirstSTepRow();
            }
        }
    }
}
