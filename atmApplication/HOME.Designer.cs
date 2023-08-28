namespace atmApplication
{
    partial class HOME
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label_atm;
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_ministatment = new System.Windows.Forms.Button();
            this.btn_balance = new System.Windows.Forms.Button();
            this.btn_changepin = new System.Windows.Forms.Button();
            this.btn_fastcash = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_out = new System.Windows.Forms.Button();
            this.ANlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            label_atm = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_atm
            // 
            label_atm.AutoSize = true;
            label_atm.BackColor = System.Drawing.Color.Transparent;
            label_atm.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_atm.ForeColor = System.Drawing.Color.Red;
            label_atm.Location = new System.Drawing.Point(74, 32);
            label_atm.Name = "label_atm";
            label_atm.Size = new System.Drawing.Size(638, 50);
            label_atm.TabIndex = 2;
            label_atm.Text = "Select Type Of Transaction";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label4.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(760, 9);
            label4.Name = "label4";
            label4.Padding = new System.Windows.Forms.Padding(1);
            label4.Size = new System.Drawing.Size(37, 36);
            label4.TabIndex = 11;
            label4.Text = "X";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label_atm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 107);
            this.panel1.TabIndex = 0;
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.DimGray;
            this.btn_deposit.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.Location = new System.Drawing.Point(83, 201);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(230, 64);
            this.btn_deposit.TabIndex = 9;
            this.btn_deposit.Text = "DEPOSIT";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_ministatment
            // 
            this.btn_ministatment.BackColor = System.Drawing.Color.DimGray;
            this.btn_ministatment.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ministatment.Location = new System.Drawing.Point(472, 271);
            this.btn_ministatment.Name = "btn_ministatment";
            this.btn_ministatment.Size = new System.Drawing.Size(230, 64);
            this.btn_ministatment.TabIndex = 10;
            this.btn_ministatment.Text = "MINI STATMENT";
            this.btn_ministatment.UseVisualStyleBackColor = false;
            this.btn_ministatment.Click += new System.EventHandler(this.btn_ministatment_Click);
            // 
            // btn_balance
            // 
            this.btn_balance.BackColor = System.Drawing.Color.DimGray;
            this.btn_balance.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_balance.Location = new System.Drawing.Point(472, 341);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(230, 64);
            this.btn_balance.TabIndex = 11;
            this.btn_balance.Text = "BALANCE";
            this.btn_balance.UseVisualStyleBackColor = false;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // btn_changepin
            // 
            this.btn_changepin.BackColor = System.Drawing.Color.DimGray;
            this.btn_changepin.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changepin.Location = new System.Drawing.Point(83, 341);
            this.btn_changepin.Name = "btn_changepin";
            this.btn_changepin.Size = new System.Drawing.Size(230, 64);
            this.btn_changepin.TabIndex = 12;
            this.btn_changepin.Text = "CHANGE PIN";
            this.btn_changepin.UseVisualStyleBackColor = false;
            this.btn_changepin.Click += new System.EventHandler(this.btn_changepin_Click);
            // 
            // btn_fastcash
            // 
            this.btn_fastcash.BackColor = System.Drawing.Color.DimGray;
            this.btn_fastcash.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fastcash.Location = new System.Drawing.Point(83, 271);
            this.btn_fastcash.Name = "btn_fastcash";
            this.btn_fastcash.Size = new System.Drawing.Size(230, 64);
            this.btn_fastcash.TabIndex = 13;
            this.btn_fastcash.Text = "FAST CASH";
            this.btn_fastcash.UseVisualStyleBackColor = false;
            this.btn_fastcash.Click += new System.EventHandler(this.btn_fastcash_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.Color.DimGray;
            this.btn_withdraw.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.Location = new System.Drawing.Point(472, 201);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(230, 64);
            this.btn_withdraw.TabIndex = 14;
            this.btn_withdraw.Text = "WITHDRAW";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.btn_out);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 15;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.Red;
            this.btn_out.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_out.Location = new System.Drawing.Point(315, 18);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(170, 64);
            this.btn_out.TabIndex = 9;
            this.btn_out.Text = "LOGOUT";
            this.btn_out.UseVisualStyleBackColor = false;
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // ANlabel
            // 
            this.ANlabel.AutoSize = true;
            this.ANlabel.BackColor = System.Drawing.Color.Transparent;
            this.ANlabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANlabel.Location = new System.Drawing.Point(402, 124);
            this.ANlabel.Name = "ANlabel";
            this.ANlabel.Size = new System.Drawing.Size(264, 30);
            this.ANlabel.TabIndex = 16;
            this.ANlabel.Text = "ACCOUNT NUMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Account Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 18;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ANlabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.btn_fastcash);
            this.Controls.Add(this.btn_changepin);
            this.Controls.Add(this.btn_balance);
            this.Controls.Add(this.btn_ministatment);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Button btn_ministatment;
        private System.Windows.Forms.Button btn_balance;
        private System.Windows.Forms.Button btn_changepin;
        private System.Windows.Forms.Button btn_fastcash;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label ANlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}