namespace atmApplication
{
    partial class Withdraw
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label_Diposit;
            System.Windows.Forms.Label YCBRS;
            System.Windows.Forms.Label labelAmountwithdraw;
            System.Windows.Forms.Label label1;
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_withdraw_logout = new System.Windows.Forms.Button();
            this.textBoxAmountwithdraw = new System.Windows.Forms.TextBox();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.labelABwithdraw = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label_Diposit = new System.Windows.Forms.Label();
            YCBRS = new System.Windows.Forms.Label();
            labelAmountwithdraw = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
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
            // label_Diposit
            // 
            label_Diposit.AutoSize = true;
            label_Diposit.BackColor = System.Drawing.Color.Transparent;
            label_Diposit.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_Diposit.ForeColor = System.Drawing.Color.Red;
            label_Diposit.Location = new System.Drawing.Point(101, 34);
            label_Diposit.Name = "label_Diposit";
            label_Diposit.Size = new System.Drawing.Size(633, 50);
            label_Diposit.TabIndex = 2;
            label_Diposit.Text = "WITHDRAW TRANSACTION";
            label_Diposit.Click += new System.EventHandler(this.label_Diposit_Click);
            // 
            // YCBRS
            // 
            YCBRS.AutoSize = true;
            YCBRS.BackColor = System.Drawing.Color.Transparent;
            YCBRS.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            YCBRS.ForeColor = System.Drawing.Color.Black;
            YCBRS.Location = new System.Drawing.Point(479, 208);
            YCBRS.Name = "YCBRS";
            YCBRS.Size = new System.Drawing.Size(0, 32);
            YCBRS.TabIndex = 35;
            // 
            // labelAmountwithdraw
            // 
            labelAmountwithdraw.AutoSize = true;
            labelAmountwithdraw.BackColor = System.Drawing.Color.Transparent;
            labelAmountwithdraw.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAmountwithdraw.ForeColor = System.Drawing.Color.Black;
            labelAmountwithdraw.Location = new System.Drawing.Point(50, 190);
            labelAmountwithdraw.Name = "labelAmountwithdraw";
            labelAmountwithdraw.Size = new System.Drawing.Size(266, 40);
            labelAmountwithdraw.TabIndex = 34;
            labelAmountwithdraw.Text = "Enter Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(12, 127);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(305, 40);
            label1.TabIndex = 39;
            label1.Text = "Account Balance:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Controls.Add(label4);
            this.panel6.Controls.Add(label_Diposit);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 107);
            this.panel6.TabIndex = 5;
            // 
            // btn_withdraw_logout
            // 
            this.btn_withdraw_logout.BackColor = System.Drawing.Color.DimGray;
            this.btn_withdraw_logout.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw_logout.Location = new System.Drawing.Point(578, 345);
            this.btn_withdraw_logout.Name = "btn_withdraw_logout";
            this.btn_withdraw_logout.Size = new System.Drawing.Size(170, 64);
            this.btn_withdraw_logout.TabIndex = 38;
            this.btn_withdraw_logout.Text = "Back";
            this.btn_withdraw_logout.UseVisualStyleBackColor = false;
            this.btn_withdraw_logout.Click += new System.EventHandler(this.btn_withdraw_logout_Click);
            // 
            // textBoxAmountwithdraw
            // 
            this.textBoxAmountwithdraw.Location = new System.Drawing.Point(437, 206);
            this.textBoxAmountwithdraw.Name = "textBoxAmountwithdraw";
            this.textBoxAmountwithdraw.Size = new System.Drawing.Size(170, 22);
            this.textBoxAmountwithdraw.TabIndex = 37;
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.Color.Gold;
            this.btn_withdraw.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.Location = new System.Drawing.Point(437, 243);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(213, 64);
            this.btn_withdraw.TabIndex = 36;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // labelABwithdraw
            // 
            this.labelABwithdraw.AutoSize = true;
            this.labelABwithdraw.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABwithdraw.Location = new System.Drawing.Point(432, 136);
            this.labelABwithdraw.Name = "labelABwithdraw";
            this.labelABwithdraw.Size = new System.Drawing.Size(105, 30);
            this.labelABwithdraw.TabIndex = 40;
            this.labelABwithdraw.Text = "Balance";
            this.labelABwithdraw.Click += new System.EventHandler(this.labelABwithdraw_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelABwithdraw);
            this.Controls.Add(label1);
            this.Controls.Add(this.btn_withdraw_logout);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBoxAmountwithdraw);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(labelAmountwithdraw);
            this.Controls.Add(YCBRS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_withdraw_logout;
        private System.Windows.Forms.TextBox textBoxAmountwithdraw;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Label labelABwithdraw;
    }
}