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
    public partial class Account : Form
    {
        public void AccountReg()
        {

        }

        public Account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountRegistratie accountRegistratie = new accountRegistratie();
            this.Hide();                           //Hide the main form before showing the secondary
            accountRegistratie.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
            this.Show();                        //When frm2 is closed, continue with the code (show main form)
        }
    }
}
