using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SBSH_reg
{
    //Methode om account te registreren
    //Accountgegevens in database opslaan
    //Inhoud van invoervelden controleren
    //Overeenkomende invoervelden controleren
    //-Rechten toekennen
    public partial class accountRegistratie : Form
    {
        // Connectie met database
        string connectionString = @"Data Source=localhost;Initial Catalog=SBSH-reg;Integrated Security=True;";
        public accountRegistratie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void accReg_Click(object sender, EventArgs e)
        {
            //Verplicht invoervelden controleren
            if (AccEmail.Text == "" || AccNaam.Text == "" || AccWW.Text == "" || AccWWHer.Text == "")
                MessageBox.Show("Vul de verplichte velden in");

            //Wachtwoorden controleren op overeenkomst
            else if (AccWW.Text != AccWWHer.Text)
                MessageBox.Show("Wachtwoord komt niet overeen");
            else
            {  //Geheugenplaats vrijmaken voor SQL connectie
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    //Gegevens opslaan in database
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Email",AccEmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Naam",AccNaam.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Wachtwoord",AccWW.Text.Trim());
                    sqlCmd.ExecuteNonQuery();

                    //Voltooiing bevestigen met messagebox
                    MessageBox.Show("Registratie is voltooid");
                    Clear();               
                }
            }
        }
        //Invoervelden leegmaken na invoer
        void Clear()
        {
            AccEmail.Text = AccNaam.Text = AccWW.Text = AccWWHer.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
