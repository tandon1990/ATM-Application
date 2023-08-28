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

namespace atmApplication
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label_AN_Click(object sender, EventArgs e)
        {

        }

        private void label_AMS_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ibrahim kedir\Documents\CSC 343\atmApplication\atmApplication\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNum;
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (textBoxCP.Text == "" || textBoxNP.Text == " ")
            {
                MessageBox.Show("Enter And Confirm The New Pin");
            }
            else if (textBoxNP.Text != textBoxCP.Text) 
            {
                MessageBox.Show("Pins Do NOT Match");
            }
            else
            {

              
                try
                {
                    Con.Open();
                    String query = "UPDATE AccountTbl2 SET PIN =  " + textBoxCP.Text + " WHERE AccNum = '" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Sucessfuly Changed");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open) // Check if the connection is open before attempting to close
                    {
                        Con.Close();
                    }

                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
