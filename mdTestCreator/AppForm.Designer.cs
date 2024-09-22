using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System.Configuration;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace mdTestCreator
{
    partial class AppForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox BoxTestname;
        private TextBox BoxDescription;
        private TextBox boxTestNumber;
        private Button bStart;
        private TabControl tabs;
        private TabPage TestPage;
        private TabPage ReportPage;
        private Label mdExtendion;
        private TestRowRecord PreviousTestRowRecord;
        private TestRowRecord FirstTestRow;
        private static SqlWrapper sql_wrapper = new SqlWrapper();
        private static MySqlConnection SqlConnection = null;
        public static int stepsQTY = 1;
        private const int indent = 10;
        public static bool isFirst = true;
        private const string mainFormCaption = "message from main Form";
        private const string mainFormExceptiton = "Exception message from main Form";

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
            MessageBox.Show("we are inside InitFirstSTepRow", "mainform", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SuspendLayout();
            SqlConnection = SqlWrapper.sqlConnection;
            FirstTestRow = new TestRowRecord();
            SqlWrapper sqlConnection = new SqlWrapper();
            FirstTestRow.Location = new Point(10, 76);
            FirstTestRow.Size = new Size(700, 32);
            FirstTestRow.TabIndex = 4;
            PreviousTestRowRecord = FirstTestRow;
            Controls.Add(FirstTestRow);
            TestPage.Controls.Add(FirstTestRow);
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
            boxTestNumber = new TextBox();
            tabs.SuspendLayout();
            TestPage.SuspendLayout();
            SuspendLayout();
            // 
            // BoxTestname
            // 
            BoxTestname.Location = new Point(60, 10);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.PlaceholderText = "Type here short test case name title(filename)";
            BoxTestname.Size = new Size(460, 23);
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
            TestPage.AutoScroll = true;
            TestPage.BackColor = Color.Transparent;
            TestPage.Controls.Add(boxTestNumber);
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
            // boxTestNumber
            // 
            boxTestNumber.BorderStyle = BorderStyle.FixedSingle;
            boxTestNumber.Enabled = false;
            boxTestNumber.Location = new Point(10, 10);
            boxTestNumber.Name = "boxTestNumber";
            boxTestNumber.Size = new Size(40, 23);
            boxTestNumber.TabIndex = 4;
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
            MessageBox.Show($"we are in Custom_AddStepButton_ButtonClicked from AddFirstSTepRow", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // we are in Custom_AddStepButton_ButtonClicked from AddFirstSTepRow
            TestRowRecord newStepRow = new TestRowRecord();
            Controls.Add(newStepRow);
            int NewRowYposition = PreviousTestRowRecord.Location.Y + PreviousTestRowRecord.Height + indent;
            TestPage.Controls.Add(newStepRow);
            newStepRow.Location = new Point(PreviousTestRowRecord.Location.X, NewRowYposition);
            MessageBox.Show($"new roe location: {NewRowYposition}{Environment.NewLine} PreviousTestRowRecord Y Location: {PreviousTestRowRecord.Location.Y}", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            PreviousTestRowRecord = newStepRow;
            ResumeLayout(true);
            TestPage.PerformLayout();
            newStepRow.SetRowNumber(stepsQTY);
            newStepRow.Size = new Size(700, 32);
            newStepRow.Custom_AddStepButton_ButtonClicked += Custom_AddStepButton_ButtonClicked;
            newStepRow.Custom_CompleteButton_ButttonClicked += Custom_CompleteButton_ButttonClicked;
            stepsQTY++;


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
            Application.Exit();
            // Optionally, do something when a new step is added
            //MessageBox.Show("Custom Complete buttton clicked", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update PreviousTestRowRecord to point to the new control
            PreviousTestRowRecord = sender as TestRowRecord;
        }
        //private void Custom_AddStepButton_ButttonClicked(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Custom_AddStepButton_ButttonClicked", "main Application Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private string Get_db__ConnectionString()
        //{
        //    string host = ConfigurationManager.AppSettings["dbHost"];
        //    string user = ConfigurationManager.AppSettings["db_User"];
        //    string pswd = ConfigurationManager.AppSettings["db_pswd"];

        //    MessageBox.Show($"Config:{ConfigurationManager.AppSettings.Get("greeting")}", mainFormCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    string ConnectionString = $"server={host};user={user};password={pswd};"; // Replace 'yourpassword' with your actual MySQL password


        //    return ConnectionString;
        //}

        

        private void bStart_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (BoxTestname.Text == string.Empty)
                {
                    MessageBox.Show("Please input short test case name.(filename)", "mainform", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (BoxTestname.Text != string.Empty)
                {
                    break;
                }
                Thread.Sleep(1000);
            }// end of while()
            InitializeComponent();
        }// end of bStart_Click

    }
}
