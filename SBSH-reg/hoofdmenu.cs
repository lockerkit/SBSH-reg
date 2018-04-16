using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBSH_reg
{
    public partial class hoofdmenu : Form
    {
        public hoofdmenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            batchRegistratie settingsForm = new batchRegistratie();

            // Show the settings form
            settingsForm.Show();
        }

        private void account_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Form2 class
            //Account settingsForm = new Account();

            // Show the settings form
            //settingsForm.Show();

            Account Account = new Account();
            this.Hide();           //Hide the main form before showing the secondary
            Account.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();           //When frm2 is closed, continue with the code (show main form)
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
