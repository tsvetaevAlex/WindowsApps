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
            // 
            // Expectedbox
            // 
            Expectedbox.Location = new Point(153, 7);
            Expectedbox.Name = "Expectedbox";
            Expectedbox.Size = new Size(100, 23);
            Expectedbox.TabIndex = 2;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(259, 7);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(75, 23);
            bAdd.TabIndex = 3;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // bComplete
            // 
            bComplete.Location = new Point(340, 7);
            bComplete.Name = "bComplete";
            bComplete.Size = new Size(72, 23);
            bComplete.TabIndex = 4;
            bComplete.Text = "Complete";
            bComplete.UseVisualStyleBackColor = true;
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
}
