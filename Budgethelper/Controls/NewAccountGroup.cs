using Budgethelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgethelper.Controls
{
    public partial class NewAccountGroup : UserControl
    {

        private static bool IsUsertext = false;

        public NewAccountGroup()
        {
            InitializeComponent();
        }

        private void NAG_textBox_AccountName_TextChanged(object sender, EventArgs e)
        {
            IsUsertext = true;
            NAG_comboBox_AccountType.DataSource = Enum.GetValues(typeof(FundsSource_Type));


        }

        private void NAG_textBox_AccountName_MouseEnter(object sender, EventArgs e)
        {
            if (!IsUsertext)
            {
                NAG_textBox_AccountName.Focus();
                NAG_textBox_AccountName.Text = string.Empty;
            }
        }
    }
}
