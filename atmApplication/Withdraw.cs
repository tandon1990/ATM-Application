using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmApplication
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ibrahim kedir\Documents\CSC 343\atmApplication\atmApplication\ATMDb.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNum;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from AccountTbl2 where AccNum='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            labelABwithdraw.Text = dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void label_Diposit_Click(object sender, EventArgs e)
        {

        }
        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();

                // Convert the Acc string to bytes (VARBINARY)
                byte[] accBytes = Encoding.UTF8.GetBytes(Acc);

                String query = "INSERT INTO TransactionTbl VALUES(@AccNum, @TrType, @Amount, @TDATE)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accBytes);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(textBoxAmountwithdraw.Text));
                cmd.Parameters.AddWithValue("@TDATE", DateTime.Today.Date.ToString());

                cmd.ExecuteNonQuery();

               
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;
        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            if (textBoxAmountwithdraw.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToUInt32(textBoxAmountwithdraw.Text) <= 0)
            {
                MessageBox.Show("Enter a Valid Amount");
            }
            else if (Convert.ToUInt32(textBoxAmountwithdraw.Text) > bal)
            {
                MessageBox.Show("Balance Can NOT Be Negative");
            }
            else 
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(textBoxAmountwithdraw.Text);
                    try
                    {
                        Con.Open();
                        String query = "UPDATE AccountTbl2 SET Balance =  " + newbalance + " WHERE AccNum = '" + Acc + "'";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successful Withdraw");
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
                        addtransaction();
                        HOME home = new HOME();
                        home.Show();
                        this.Hide();
                    }
                }
                catch (Exception Ex) 
                {
                    MessageBox.Show(Ex.Message);
                }
            }
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

        private void labelABwithdraw_Click(object sender, EventArgs e)
        {

        }
    }
}
