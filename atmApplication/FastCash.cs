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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private void labelAmountwithdraw_Click(object sender, EventArgs e)
        {

        }

       

        private void YCBRS_Click(object sender, EventArgs e)
        {

        }
         
        private void btn_back_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
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
            labelABfastcash.Text = dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void FastCash_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        int amt;
        private void addtransaction1()
        {
            string TrType = "Fast Cash";
            try
            {
                Con.Open();

                // Convert the Acc string to bytes (VARBINARY)
                byte[] accBytes = Encoding.UTF8.GetBytes(Acc);

                String query = "INSERT INTO TransactionTbl VALUES(@AccNum, @TrType, @Amount, @TDATE)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accBytes);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(btn_50.Text));
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
        private void addtransaction2()
        {
            string TrType = "Fast Cash";
            try
            {
                Con.Open();

                // Convert the Acc string to bytes (VARBINARY)
                byte[] accBytes = Encoding.UTF8.GetBytes(Acc);

                String query = "INSERT INTO TransactionTbl VALUES(@AccNum, @TrType, @Amount, @TDATE)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accBytes);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(btn_100.Text));
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
        private void addtransaction3()
        {
            string TrType = "Fast Cash";
            try
            {
                Con.Open();

                // Convert the Acc string to bytes (VARBINARY)
                byte[] accBytes = Encoding.UTF8.GetBytes(Acc);

                String query = "INSERT INTO TransactionTbl VALUES(@AccNum, @TrType, @Amount, @TDATE)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accBytes);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(btn_200.Text));
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
        private void addtransaction4()
        {
            string TrType = "Fast Cash";
            try
            {
                Con.Open();

                // Convert the Acc string to bytes (VARBINARY)
                byte[] accBytes = Encoding.UTF8.GetBytes(Acc);

                String query = "INSERT INTO TransactionTbl VALUES(@AccNum, @TrType, @Amount, @TDATE)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accBytes);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(btn_500.Text));
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
        private void addtransaction5()
        {
            string TrType = "Fast Cash";
            try
            {
                Con.Open();

                // Convert the Acc string to bytes (VARBINARY)
                byte[] accBytes = Encoding.UTF8.GetBytes(Acc);

                String query = "INSERT INTO TransactionTbl VALUES(@AccNum, @TrType, @Amount, @TDATE)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accBytes);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(btn_1000.Text));
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
        private void addtransaction6()
        {
            string TrType = "Fast Cash";
            try
            {
                Con.Open();

                // Convert the Acc string to bytes (VARBINARY)
                byte[] accBytes = Encoding.UTF8.GetBytes(Acc);

                String query = "INSERT INTO TransactionTbl VALUES(@AccNum, @TrType, @Amount, @TDATE)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@AccNum", accBytes);
                cmd.Parameters.AddWithValue("@TrType", TrType);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToInt32(btn_2000.Text));
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





        private void btn_50_Click(object sender, EventArgs e)
        {
            if (bal < 50)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else 
            {
                int newbalance = bal - 50;
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
                        addtransaction1();
                    }

                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 100;
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
                        addtransaction2();
                    }

                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            if (bal < 200)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 200;
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
                        addtransaction3();
                    }

                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 500;
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
                        addtransaction4();
                    }

                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

       

        private void btn_1000_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 1000;
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
                        addtransaction5();
                    }

                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void btn_2000_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 2000;
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
                        addtransaction6();
                    }

                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
