namespace atmApplication
{
    partial class Deposit
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
            System.Windows.Forms.Label labelAmount;
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_deposit_logout = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.btn_deposit = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label_Diposit = new System.Windows.Forms.Label();
            YCBRS = new System.Windows.Forms.Label();
            labelAmount = new System.Windows.Forms.Label();
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
            label_Diposit.Location = new System.Drawing.Point(128, 37);
            label_Diposit.Name = "label_Diposit";
            label_Diposit.Size = new System.Drawing.Size(566, 50);
            label_Diposit.TabIndex = 2;
            label_Diposit.Text = "DEPOSIT TRANSACTION";
            // 
            // YCBRS
            // 
            YCBRS.AutoSize = true;
            YCBRS.BackColor = System.Drawing.Color.Transparent;
            YCBRS.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            YCBRS.ForeColor = System.Drawing.Color.Black;
            YCBRS.Location = new System.Drawing.Point(491, 228);
            YCBRS.Name = "YCBRS";
            YCBRS.Size = new System.Drawing.Size(0, 32);
            YCBRS.TabIndex = 29;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.BackColor = System.Drawing.Color.Transparent;
            labelAmount.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAmount.ForeColor = System.Drawing.Color.Black;
            labelAmount.Location = new System.Drawing.Point(154, 181);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new System.Drawing.Size(147, 32);
            labelAmount.TabIndex = 27;
            labelAmount.Text = "AMOUNT";
            labelAmount.Click += new System.EventHandler(this.labelCP_Click);
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
            this.panel6.TabIndex = 4;
            // 
            // btn_deposit_logout
            // 
            this.btn_deposit_logout.BackColor = System.Drawing.Color.DimGray;
            this.btn_deposit_logout.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit_logout.Location = new System.Drawing.Point(590, 365);
            this.btn_deposit_logout.Name = "btn_deposit_logout";
            this.btn_deposit_logout.Size = new System.Drawing.Size(170, 64);
            this.btn_deposit_logout.TabIndex = 33;
            this.btn_deposit_logout.Text = "Back";
            this.btn_deposit_logout.UseVisualStyleBackColor = false;
            this.btn_deposit_logout.Click += new System.EventHandler(this.btn_deposit_logout_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(355, 191);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(170, 22);
            this.textBoxAmount.TabIndex = 32;
            // 
            // btn_deposit
            // 
            this.btn_deposit.BackColor = System.Drawing.Color.Gold;
            this.btn_deposit.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposit.Location = new System.Drawing.Point(355, 272);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(170, 64);
            this.btn_deposit.TabIndex = 30;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = false;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_deposit_logout);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.btn_deposit);
            this.Controls.Add(YCBRS);
            this.Controls.Add(labelAmount);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_deposit_logout;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button btn_deposit;
    }
}