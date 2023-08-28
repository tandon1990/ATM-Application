using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmApplication
{
    public partial class MiniStatment : Form
    {
        public MiniStatment()
        {
            InitializeComponent();
        }

  

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ibrahim kedir\Documents\CSC 343\atmApplication\atmApplication\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNum;
        private void Populate() 
        {
            Con.Open();
            string query = "SELECT * FROM TransactionTbl WHERE AccNum = '" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MiniStatment_Load(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            Populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_withdraw_logout_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }
    }
}
