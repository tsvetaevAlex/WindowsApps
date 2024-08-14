using mdTest.CustomElment;
namespace mdTest
{
    partial class AppForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Panel Templatepanel;
        private  TestRow CustomControl = new TestRow();

        private void AddTestStep_ButtonClicked()
        {
            MessageBox.Show("AddTestStep_ButtonClicked button was clicked!", "MainForm", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void CompleteRecord_ButtonClicked()
        {
            MessageBox.Show("CompleteRecord_ButtonClicked button was clicked!", "MainForm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }// Подписка на события
                
                // Обработчик для события AddTestStep_ButtonClicked
                private void CustomControl_AddTestStep_ButtonClicked(object sender, EventArgs e)
                {
                    MessageBox.Show("AddTestStep button was clicked! Hello from main form");
                    // Ваша логика для обработки нажатия кнопки AddTestStep
                }

                // Обработчик для события CompleteRecord_ButtonClicked
                private void CustomControl_CompleteRecord_ButtonClicked(object sender, EventArgs e)
                {
                    MessageBox.Show("CompleteRecord button was clicked! Hello from main form");
                    // Ваша логика для обработки нажатия кнопки CompleteRecord
                }
        
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
        #region exmaple of names to do not go across solution to finsd spelling
        #endregion
        //testRow.bComplete_Click += new EventHandler(bComplete_Click(object sender, EventArgs e));

        //private void addTestStep(object sender, EventArgs e)
        //{
        //    testRow.AddTestStep_ButttonClicked += TestRow_AddTestStep_ButttonClicked;
        //}
        //private void cOMPLETEtESTcREATION(object sender, EventArgs e)
        //{
        //    testRow.CompleteRecord_ButttonClicked += CompleteRecord_ButttonClicked;
        //}

        private void bComplete_Click(object sender, EventArgs e)
        {
            //this.bComplete.Click += neEventHandler(this.CompleteRecord_ButttonClicked);
            string caption = "Hi from parent form";
            const string message = "using this button, you can complete test case creation";
            MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //private void bAddTestStep_Click(object sender, EventArgs e)
        //{

        //    //this.bAddTestStep.Click += new EventHandler(this.AddTestStep_ButttonClicked);
        //    string caption = "Hi from custom";
        //    const string message = "using this button, you will add one more test step";
        //    MessageBox.Show(message, caption,
        //                    MessageBoxButtons.OK,
        //                    MessageBoxIcon.Information);
        //}
        private void TestRow_AddTestStep_ButttonClicked(object sender, EventArgs e)
        {
            string caption = "Hi from Main Form";
            const string message = "using this button, you will add one more test step";
            MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }
        private void CompleteRecord_ButttonClicked(object sender, EventArgs e)
        {
            string caption = "Hi from Main Form";
            const string message = "using this button, you can complete test casae crestion";
            MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #region Windows Form Designer generated code

        private void addTestRow_ButttonClicked(object sender, EventArgs e)
        {
            //enable button here
        }
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Templatepanel = new Panel();
            tabControl = new TabControl();
            testPage = new TabPage();
            startButton = new Button();
            mdExtendion = new Label();
            BoxTestname = new TextBox();
            testRow = new TestRow();
            BoxDescription = new TextBox();
            BoxDescsription = new TextBox();
            reportPage = new TabPage();
            tabControl.SuspendLayout();
            testPage.SuspendLayout();
            SuspendLayout();
            // 
            // Templatepanel
            // 
            Templatepanel.Location = new Point(0, 0);
            Templatepanel.Name = "Templatepanel";
            Templatepanel.Size = new Size(200, 100);
            Templatepanel.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(testPage);
            tabControl.Controls.Add(reportPage);
            tabControl.ItemSize = new Size(67, 20);
            tabControl.Location = new Point(7, 7);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(805, 710);
            tabControl.TabIndex = 0;
            // 
            // testPage
            // 
            testPage.Controls.Add(startButton);
            testPage.Controls.Add(mdExtendion);
            testPage.Controls.Add(BoxTestname);
            testPage.Controls.Add(testRow);
            testPage.Controls.Add(BoxDescription);
            testPage.Controls.Add(BoxDescsription);
            testPage.Location = new Point(4, 24);
            testPage.Name = "testPage";
            testPage.Padding = new Padding(3);
            testPage.Size = new Size(797, 682);
            testPage.TabIndex = 0;
            testPage.Text = "Test Writer";
            testPage.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Location = new Point(479, 16);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 7;
            startButton.Text = "let`s Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // mdExtendion
            // 
            mdExtendion.AutoSize = true;
            mdExtendion.Location = new Point(438, 17);
            mdExtendion.Name = "mdExtendion";
            mdExtendion.Size = new Size(28, 15);
            mdExtendion.TabIndex = 6;
            mdExtendion.Text = ".md";
            // 
            // BoxTestname
            // 
            BoxTestname.Location = new Point(1, 12);
            BoxTestname.Name = "BoxTestname";
            BoxTestname.PlaceholderText = "введите назвние теста | оно же имя файла, на английском и коротко.";
            BoxTestname.Size = new Size(429, 23);
            BoxTestname.TabIndex = 5;
            // 
            // testRow
            // 
            testRow.Location = new Point(6, 125);
            testRow.Name = "testRow";
            testRow.Size = new Size(419, 40);
            testRow.TabIndex = 4;
            testRow.Load += testRow_Load;
            // 
            // BoxDescription
            // 
            BoxDescription.Location = new Point(0, 0);
            BoxDescription.Name = "BoxDescription";
            BoxDescription.Size = new Size(100, 23);
            BoxDescription.TabIndex = 8;
            // 
            // BoxDescsription
            // 
            BoxDescsription.BorderStyle = BorderStyle.FixedSingle;
            BoxDescsription.Location = new Point(0, 47);
            BoxDescsription.Multiline = true;
            BoxDescsription.Name = "BoxDescsription";
            BoxDescsription.Size = new Size(757, 72);
            BoxDescsription.TabIndex = 2;
            BoxDescsription.Text = "в этом поле добавьте описание того, чтои как  тест порверяет.";
            // 
            // reportPage
            // 
            reportPage.Location = new Point(4, 24);
            reportPage.Name = "reportPage";
            reportPage.Padding = new Padding(3);
            reportPage.Size = new Size(797, 682);
            reportPage.TabIndex = 1;
            reportPage.Text = "Report Writer";
            reportPage.UseVisualStyleBackColor = true;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 729);
            Controls.Add(tabControl);
            Name = "AppForm";
            Text = ".md Test Writer";
            tabControl.ResumeLayout(false);
            testPage.ResumeLayout(false);
            testPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        #region  Обработчики для событий AddTestStep_ButtonClicked  CompleteRecord_ButtonClicked

        // Обработчик для события AddTestStep_ButtonClicked
        private void CustomControl_AddStep_ButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("AddTestStep button was clicked!", "AppForm : Form",MessageBoxButtons.OK,MessageBoxIcon.Information);
            // Ваша логика для обработки нажатия кнопки AddTestStep
        }

        // Обработчик для события CompleteRecord_ButtonClicked
        private void CustomControl_Complete_ButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("CompleteRecord button was clicked!", "AppForm : Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Ваша логика для обработки нажатия кнопки CompleteRecord
        }

        private void Add_TestCase_step(object sender, EventArgs e)
        {

        }
        #endregion

        private TabControl tabControl;
        private TabPage testPage;
        private TabPage reportPage;
        private TextBox BoxDescsription;
        private TextBox BoxDescription;
        private TestRow testRow;
        private Button startButton;
        private Label mdExtendion;
        private TextBox BoxTestname;
    }
}
