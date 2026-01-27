using System.Windows.Forms;
using Budgethelper.Services;

namespace Budgethelper.Forms
{
    public partial class LoginForm : Form
    {
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            var registry = new RegistryService();

            if (registry.CheckPassword(txtPassword.Text))
            {
                Program.Logger?.LogInfo("Authorized");
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}
