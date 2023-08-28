using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmApplication
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();

        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void btn_fastcash_Click(object sender, EventArgs e)
        {
            FastCash Fcash = new FastCash();
            Fcash.Show();
            this.Hide();
        }

        private void btn_changepin_Click(object sender, EventArgs e)
        {
            ChangePin Pin = new ChangePin();
            Pin.Show();
            this.Hide();
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }

        private void btn_ministatment_Click(object sender, EventArgs e)
        {
            MiniStatment minis = new MiniStatment();
            minis.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        public static String AccNum;
        private void HOME_Load(object sender, EventArgs e)
        {
            ANlabel.Text = "Account Number: " + Login.AccNum;
            AccNum = Login.AccNum;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
