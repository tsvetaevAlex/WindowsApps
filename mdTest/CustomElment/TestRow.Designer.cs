namespace mdTest.CustomElment
{
    partial class TestRow : UserControl

    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public event EventHandler FromCustom_AddStep_ButttonClicked;

        public event EventHandler FromCustom_Complete_ButttonClicked;


        #region  event handlers
        private void CustomdsControl_AddTestStep_ButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("AddTestStep button was clicked!");
            // Ваша логика для обработки нажатия кнопки AddTestStep
        }

        // Обработчик для события CompleteRecord_ButtonClicked
        private void CustomControl_CompleteRecord_ButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("CompleteRecord button was clicked!");
            // Ваша логика для обработки нажатия кнопки CompleteRecord
        }
        #endregion
        //AddRow_Clicked?.Invoke(this, e);



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
            NumberLabel = new Label();
            StepBox = new TextBox();
            Expectedbox = new TextBox();
            bAdd = new Button();
            bComplete = new Button();
            SuspendLayout();
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Location = new Point(16, 10);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(13, 15);
            NumberLabel.TabIndex = 0;
            NumberLabel.Text = "1";
            // 
            // StepBox
            // 
            StepBox.Location = new Point(47, 7);
            StepBox.Name = "StepBox";
            StepBox.Size = new Size(100, 23);
            StepBox.TabIndex = 1;
            StepBox.TextChanged += StepBox_TextChanged;
            // 
            // Expectedbox
            // 
            Expectedbox.Location = new Point(153, 7);
            Expectedbox.Name = "Expectedbox";
            Expectedbox.Size = new Size(100, 23);
            Expectedbox.TabIndex = 2;
            Expectedbox.TextChanged += Expectedbox_TextChanged;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(259, 7);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 3;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // bComplete
            // 
            bComplete.Location = new Point(340, 7);
            bComplete.Name = "bComplete";
            bComplete.Size = new Size(72, 23);
            bComplete.TabIndex = 4;
            bComplete.Text = "Complete";
            bComplete.UseVisualStyleBackColor = true;
            bComplete.Click += bComplete_Click;
            // 
            // TestRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bComplete);
            Controls.Add(bAdd);
            Controls.Add(Expectedbox);
            Controls.Add(StepBox);
            Controls.Add(NumberLabel);
            Name = "TestRow";
            Size = new Size(419, 40);
            Load += TestRow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumberLabel;
        private TextBox StepBox;
        private TextBox Expectedbox;
        private Button bAdd;
        private Button bComplete;
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

    //private void bComplete_Click(object sender, EventArgs e)
    //{
    //    //this.bComplete.Click += neEventHandler(this.CompleteRecord_ButttonClicked);
    //    string caption = "Hi from custom";
    //    const string message = "using this button, you can complete test casae crestion";
    //    MessageBox.Show(message, caption,
    //                    MessageBoxButtons.OK,
    //                    MessageBoxIcon.Information);
    //}

}