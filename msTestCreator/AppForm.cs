    
namespace mdTestCreator
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            //SqlWrapper sql = new SqlWrapper();
            //sql.InitDB();
            InitializeComponent();
        }

        private void BoxTestname_TextChanged(object sender, EventArgs e)
        {
            testFileName = BoxTestname.Text;
        }

        private void TestDataButton_MouseClick(object sender, MouseEventArgs e)
        {
            BoxTestname.Text = "0001_testCase_testMarkdown";
            BoxDescription.Text = "test of test for test";
        }

    }
}
