namespace mdTest
{
    public partial class AppForm : Form
    {

        public AppForm()
        {
            InitializeComponent();
            // events Subscription
            CustomControl.FromCustom_AddStep_ButttonClicked += CustomControl_AddStep_ButtonClicked;
            CustomControl.FromCustom_Complete_ButttonClicked += CustomControl_Complete_ButtonClicked;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (BoxTestname.Text == string.Empty)
            {
                MessageBox.Show("Please Enter valid test case name", "ВНИМАНИЕ!z", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void testRow_Load(object sender, EventArgs e)
        {

        }
    }
}
