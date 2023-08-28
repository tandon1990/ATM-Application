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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ibrahim kedir\Documents\CSC 343\atmApplication\atmApplication\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void labelDOB_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (textBoxACCNUM.Text == "" || textBoxLASTNAME.Text == "" || textBoxFIRSTNAME.Text == "" || textBoxADDRESS.Text == "" || textBoxPHONE.Text == "" || textBoxPIN.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string country = comboBoxcountry.SelectedItem?.ToString() ?? ""; // Use the selected item or an empty string if none is selected
                    String query = "insert into AccountTbl2 values('" + textBoxACCNUM.Text + "','" + textBoxFIRSTNAME.Text + "', '" + textBoxLASTNAME.Text + "', '" + DOBtimer.Value.Date + "','" + textBoxPHONE.Text + "','" + textBoxADDRESS.Text + "','" + textBoxPIN.Text + "','" + comboBoxcountry.SelectedIndex.ToString() + "','" + bal + "' )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Login Log = new Login();
                    Log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                        Con.Close(); // Ensure the connection is closed no matter what
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
