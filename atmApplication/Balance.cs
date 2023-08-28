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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ibrahim kedir\Documents\CSC 343\atmApplication\atmApplication\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void getbalance() 
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl2 where AccNum='" + ANlabelBI.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            labelCB.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        public static String AccNum;
        private void Balance_Load(object sender, EventArgs e)
        {
            ANlabelBI.Text =  Login.AccNum;
            AccNum = Login.AccNum;
            getbalance();

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
