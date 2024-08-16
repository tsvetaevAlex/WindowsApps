namespace mdTestCreator
{
    public partial class AppForm : Form
    {
        private const string capture  = "Message from Application Main Form";
        public AppForm()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (BoxTestname.Text == string.Empty)
            {
                MessageBox.Show("Please input short test case name.(filename)",capture,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
