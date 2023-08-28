namespace atmApplication
{
    partial class Balance
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
            System.Windows.Forms.Label label_AMS;
            System.Windows.Forms.Label label_AN;
            System.Windows.Forms.Label labelbalance;
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.ANlabelBI = new System.Windows.Forms.Label();
            this.labelCB = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label_AMS = new System.Windows.Forms.Label();
            label_AN = new System.Windows.Forms.Label();
            labelbalance = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
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
            // label_AMS
            // 
            label_AMS.AutoSize = true;
            label_AMS.BackColor = System.Drawing.Color.Transparent;
            label_AMS.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_AMS.ForeColor = System.Drawing.Color.Red;
            label_AMS.Location = new System.Drawing.Point(192, 30);
            label_AMS.Name = "label_AMS";
            label_AMS.Size = new System.Drawing.Size(443, 50);
            label_AMS.TabIndex = 2;
            label_AMS.Text = "BALANCE INQUIRY";
            // 
            // label_AN
            // 
            label_AN.AutoSize = true;
            label_AN.BackColor = System.Drawing.Color.Transparent;
            label_AN.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_AN.ForeColor = System.Drawing.Color.Black;
            label_AN.Location = new System.Drawing.Point(119, 135);
            label_AN.Name = "label_AN";
            label_AN.Size = new System.Drawing.Size(300, 39);
            label_AN.TabIndex = 13;
            label_AN.Text = "Account Number:";
            // 
            // labelbalance
            // 
            labelbalance.AutoSize = true;
            labelbalance.BackColor = System.Drawing.Color.Transparent;
            labelbalance.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelbalance.ForeColor = System.Drawing.Color.Black;
            labelbalance.Location = new System.Drawing.Point(12, 234);
            labelbalance.Name = "labelbalance";
            labelbalance.Size = new System.Drawing.Size(407, 39);
            labelbalance.TabIndex = 14;
            labelbalance.Text = "Your Current Banalnce:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Controls.Add(label4);
            this.panel5.Controls.Add(label_AMS);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 107);
            this.panel5.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DimGray;
            this.btn_back.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(320, 351);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(170, 64);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ANlabelBI
            // 
            this.ANlabelBI.AutoSize = true;
            this.ANlabelBI.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANlabelBI.Location = new System.Drawing.Point(558, 144);
            this.ANlabelBI.Name = "ANlabelBI";
            this.ANlabelBI.Size = new System.Drawing.Size(147, 30);
            this.ANlabelBI.TabIndex = 18;
            this.ANlabelBI.Text = "ANlabelBI";
            // 
            // labelCB
            // 
            this.labelCB.AutoSize = true;
            this.labelCB.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCB.Location = new System.Drawing.Point(558, 243);
            this.labelCB.Name = "labelCB";
            this.labelCB.Size = new System.Drawing.Size(112, 30);
            this.labelCB.TabIndex = 19;
            this.labelCB.Text = "Balance";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCB);
            this.Controls.Add(this.ANlabelBI);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(labelbalance);
            this.Controls.Add(label_AN);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label ANlabelBI;
        private System.Windows.Forms.Label labelCB;
    }
}