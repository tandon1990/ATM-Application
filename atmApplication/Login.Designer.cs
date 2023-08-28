namespace atmApplication
{
    partial class Login
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxACCNUM = new System.Windows.Forms.TextBox();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.btn_login1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            label_atm = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_atm
            // 
            label_atm.AutoSize = true;
            label_atm.BackColor = System.Drawing.Color.Transparent;
            label_atm.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_atm.ForeColor = System.Drawing.Color.Red;
            label_atm.Location = new System.Drawing.Point(63, 29);
            label_atm.Name = "label_atm";
            label_atm.Size = new System.Drawing.Size(685, 50);
            label_atm.TabIndex = 1;
            label_atm.Text = "WELLS FARGO ATM MACHINE";
            label_atm.Click += new System.EventHandler(this.label_atm_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Gold;
            label1.Location = new System.Drawing.Point(306, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(166, 50);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(306, 208);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(153, 32);
            label2.TabIndex = 4;
            label2.Text = "ACC NUM";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(309, 262);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 32);
            label3.TabIndex = 5;
            label3.Text = "PIN CODE";
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
            label4.TabIndex = 10;
            label4.Text = "X";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(label_atm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 108);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 131);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxACCNUM
            // 
            this.textBoxACCNUM.Location = new System.Drawing.Point(484, 218);
            this.textBoxACCNUM.Name = "textBoxACCNUM";
            this.textBoxACCNUM.Size = new System.Drawing.Size(181, 22);
            this.textBoxACCNUM.TabIndex = 6;
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(484, 272);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(181, 22);
            this.textBoxPIN.TabIndex = 7;
            // 
            // btn_login1
            // 
            this.btn_login1.BackColor = System.Drawing.Color.DimGray;
            this.btn_login1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login1.Location = new System.Drawing.Point(593, 314);
            this.btn_login1.Name = "btn_login1";
            this.btn_login1.Size = new System.Drawing.Size(170, 64);
            this.btn_login1.TabIndex = 8;
            this.btn_login1.Text = "LOGIN";
            this.btn_login1.UseVisualStyleBackColor = false;
            this.btn_login1.Click += new System.EventHandler(this.btn_login1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(593, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "SIGN UP";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_login1);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.textBoxACCNUM);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxACCNUM;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Button btn_login1;
        private System.Windows.Forms.Button button2;
    }
}