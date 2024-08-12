namespace mdTest.CustomElment
{
    partial class TestRow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            labelNumber = new Label();
            boxStep = new TextBox();
            boxExpected = new TextBox();
            bAddTestStep = new Button();
            bComplete = new Button();
            SuspendLayout();
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(16, 10);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(13, 15);
            labelNumber.TabIndex = 0;
            labelNumber.Text = "1";
            // 
            // boxStep
            // 
            boxStep.Location = new Point(47, 7);
            boxStep.Name = "boxStep";
            boxStep.Size = new Size(100, 23);
            boxStep.TabIndex = 1;
            // 
            // boxExpected
            // 
            boxExpected.Location = new Point(153, 7);
            boxExpected.Name = "boxExpected";
            boxExpected.Size = new Size(100, 23);
            boxExpected.TabIndex = 2;
            // 
            // bAddTestStep
            // 
            bAddTestStep.FlatStyle = FlatStyle.Flat;
            bAddTestStep.Location = new Point(259, 7);
            bAddTestStep.Name = "bAddTestStep";
            bAddTestStep.Size = new Size(75, 23);
            bAddTestStep.TabIndex = 3;
            bAddTestStep.Text = "Add Step";
            bAddTestStep.UseVisualStyleBackColor = true;
            bAddTestStep.Click += bAddTestStep_Click;
            //this.bAddTestStep.Click += new System.EventHandler(this.AddTestStep_ButttonClicked);
            // 
            // bComplete
            // 
            bComplete.FlatStyle = FlatStyle.Flat;
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
            Controls.Add(bAddTestStep);
            Controls.Add(boxExpected);
            Controls.Add(boxStep);
            Controls.Add(labelNumber);
            Name = "TestRow";
            Size = new Size(419, 40);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumber;
        private TextBox boxStep;
        private TextBox boxExpected;
        private Button bAddTestStep;
        private Button bComplete;
    }
}
