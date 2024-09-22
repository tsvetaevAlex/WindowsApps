    
namespace mdTestCreator
{
    public partial class AppForm : Form
    {
        private const string mainformCaptions = "Application main form";
        public AppForm()
        {
            SqlWrapper sql = new SqlWrapper();
            sql.InitDB();
            InitializeComponent();
        }
    }
}
