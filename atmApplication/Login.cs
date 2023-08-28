using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_atm_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        
        }
        public static String AccNum;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ibrahim kedir\Documents\CSC 343\atmApplication\atmApplication\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void btn_login1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl2 where AccNum='" + textBoxACCNUM.Text + "' and PIN =" + textBoxPIN.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccNum = textBoxACCNUM.Text;
                HOME home = new HOME();
                home.Show();
                this.Hide();
                Con.Close();
            }
            else 
            {
                MessageBox.Show("Wrong Account Number OR PIN Code");
            }
            Con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
