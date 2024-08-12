
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace mdTest.CustomElment
{
    public partial class TestRow : UserControl
    {
        public TestRow()
        {
            InitializeComponent();
        }
        public event EventHandler AddTestStep_ButttonClicked;
        public event EventHandler CompleteRecord_ButttonClicked;

        private void bComplete_Click(object sender, EventArgs e)
        {
            //this.bComplete.Click += neEventHandler(this.CompleteRecord_ButttonClicked);
            string caption = "Hi from custom";
            const string message = "using this button, you can complete test casae crestion";
            MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void bAddTestStep_Click(object sender, EventArgs e)
        {
            
            //this.bAddTestStep.Click += new EventHandler(this.AddTestStep_ButttonClicked);
            string caption = "Hi from custom";
            const string message = "using this button, you will add one more test step";
            MessageBox.Show(message, caption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}