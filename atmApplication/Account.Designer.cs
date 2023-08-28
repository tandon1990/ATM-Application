namespace atmApplication
{
    partial class Account
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
            System.Windows.Forms.Label labelPHONE;
            System.Windows.Forms.Label labelFNAME;
            System.Windows.Forms.Label labelADRESS;
            System.Windows.Forms.Label labelLN;
            System.Windows.Forms.Label labelDOB;
            System.Windows.Forms.Label labelBALANCE;
            System.Windows.Forms.Label labelPIN;
            System.Windows.Forms.Label label1;
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxACCNUM = new System.Windows.Forms.TextBox();
            this.textBoxLASTNAME = new System.Windows.Forms.TextBox();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.textBoxPHONE = new System.Windows.Forms.TextBox();
            this.textBoxFIRSTNAME = new System.Windows.Forms.TextBox();
            this.textBoxADDRESS = new System.Windows.Forms.TextBox();
            this.DOBtimer = new System.Windows.Forms.DateTimePicker();
            this.comboBoxcountry = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label_AMS = new System.Windows.Forms.Label();
            label_AN = new System.Windows.Forms.Label();
            labelPHONE = new System.Windows.Forms.Label();
            labelFNAME = new System.Windows.Forms.Label();
            labelADRESS = new System.Windows.Forms.Label();
            labelLN = new System.Windows.Forms.Label();
            labelDOB = new System.Windows.Forms.Label();
            labelBALANCE = new System.Windows.Forms.Label();
            labelPIN = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
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
            label_AMS.Location = new System.Drawing.Point(74, 32);
            label_AMS.Name = "label_AMS";
            label_AMS.Size = new System.Drawing.Size(633, 50);
            label_AMS.TabIndex = 2;
            label_AMS.Text = "ATM MANAGMENT SYSTEM";
            // 
            // label_AN
            // 
            label_AN.AutoSize = true;
            label_AN.BackColor = System.Drawing.Color.Transparent;
            label_AN.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_AN.ForeColor = System.Drawing.Color.Black;
            label_AN.Location = new System.Drawing.Point(64, 134);
            label_AN.Name = "label_AN";
            label_AN.Size = new System.Drawing.Size(153, 32);
            label_AN.TabIndex = 12;
            label_AN.Text = "ACC NUM";
            label_AN.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPHONE
            // 
            labelPHONE.AutoSize = true;
            labelPHONE.BackColor = System.Drawing.Color.Transparent;
            labelPHONE.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPHONE.ForeColor = System.Drawing.Color.Black;
            labelPHONE.Location = new System.Drawing.Point(64, 311);
            labelPHONE.Name = "labelPHONE";
            labelPHONE.Size = new System.Drawing.Size(117, 32);
            labelPHONE.TabIndex = 13;
            labelPHONE.Text = "PHONE";
            labelPHONE.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelFNAME
            // 
            labelFNAME.AutoSize = true;
            labelFNAME.BackColor = System.Drawing.Color.Transparent;
            labelFNAME.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelFNAME.ForeColor = System.Drawing.Color.Black;
            labelFNAME.Location = new System.Drawing.Point(64, 223);
            labelFNAME.Name = "labelFNAME";
            labelFNAME.Size = new System.Drawing.Size(192, 32);
            labelFNAME.TabIndex = 14;
            labelFNAME.Text = "FIRST NAME";
            // 
            // labelADRESS
            // 
            labelADRESS.AutoSize = true;
            labelADRESS.BackColor = System.Drawing.Color.Transparent;
            labelADRESS.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelADRESS.ForeColor = System.Drawing.Color.Black;
            labelADRESS.Location = new System.Drawing.Point(64, 267);
            labelADRESS.Name = "labelADRESS";
            labelADRESS.Size = new System.Drawing.Size(150, 32);
            labelADRESS.TabIndex = 15;
            labelADRESS.Text = "ADDRESS";
            // 
            // labelLN
            // 
            labelLN.AutoSize = true;
            labelLN.BackColor = System.Drawing.Color.Transparent;
            labelLN.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelLN.ForeColor = System.Drawing.Color.Black;
            labelLN.Location = new System.Drawing.Point(64, 179);
            labelLN.Name = "labelLN";
            labelLN.Size = new System.Drawing.Size(183, 32);
            labelLN.TabIndex = 16;
            labelLN.Text = "LAST NAME";
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.BackColor = System.Drawing.Color.Transparent;
            labelDOB.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelDOB.ForeColor = System.Drawing.Color.Black;
            labelDOB.Location = new System.Drawing.Point(447, 277);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new System.Drawing.Size(78, 32);
            labelDOB.TabIndex = 17;
            labelDOB.Text = "DOB";
            labelDOB.Click += new System.EventHandler(this.labelDOB_Click);
            // 
            // labelBALANCE
            // 
            labelBALANCE.AutoSize = true;
            labelBALANCE.BackColor = System.Drawing.Color.Transparent;
            labelBALANCE.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelBALANCE.ForeColor = System.Drawing.Color.Black;
            labelBALANCE.Location = new System.Drawing.Point(447, 189);
            labelBALANCE.Name = "labelBALANCE";
            labelBALANCE.Size = new System.Drawing.Size(0, 32);
            labelBALANCE.TabIndex = 18;
            // 
            // labelPIN
            // 
            labelPIN.AutoSize = true;
            labelPIN.BackColor = System.Drawing.Color.Transparent;
            labelPIN.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPIN.ForeColor = System.Drawing.Color.Black;
            labelPIN.Location = new System.Drawing.Point(453, 189);
            labelPIN.Name = "labelPIN";
            labelPIN.Size = new System.Drawing.Size(64, 32);
            labelPIN.TabIndex = 19;
            labelPIN.Text = "PIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(447, 233);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 32);
            label1.TabIndex = 30;
            label1.Text = "COUNTRY";
            label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(label4);
            this.panel4.Controls.Add(label_AMS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 107);
            this.panel4.TabIndex = 1;
            // 
            // textBoxACCNUM
            // 
            this.textBoxACCNUM.Location = new System.Drawing.Point(285, 144);
            this.textBoxACCNUM.Name = "textBoxACCNUM";
            this.textBoxACCNUM.Size = new System.Drawing.Size(143, 22);
            this.textBoxACCNUM.TabIndex = 20;
            // 
            // textBoxLASTNAME
            // 
            this.textBoxLASTNAME.Location = new System.Drawing.Point(285, 189);
            this.textBoxLASTNAME.Name = "textBoxLASTNAME";
            this.textBoxLASTNAME.Size = new System.Drawing.Size(143, 22);
            this.textBoxLASTNAME.TabIndex = 22;
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(523, 199);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(265, 22);
            this.textBoxPIN.TabIndex = 23;
            // 
            // textBoxPHONE
            // 
            this.textBoxPHONE.Location = new System.Drawing.Point(285, 321);
            this.textBoxPHONE.Name = "textBoxPHONE";
            this.textBoxPHONE.Size = new System.Drawing.Size(143, 22);
            this.textBoxPHONE.TabIndex = 25;
            // 
            // textBoxFIRSTNAME
            // 
            this.textBoxFIRSTNAME.Location = new System.Drawing.Point(285, 233);
            this.textBoxFIRSTNAME.Name = "textBoxFIRSTNAME";
            this.textBoxFIRSTNAME.Size = new System.Drawing.Size(143, 22);
            this.textBoxFIRSTNAME.TabIndex = 26;
            // 
            // textBoxADDRESS
            // 
            this.textBoxADDRESS.Location = new System.Drawing.Point(285, 277);
            this.textBoxADDRESS.Name = "textBoxADDRESS";
            this.textBoxADDRESS.Size = new System.Drawing.Size(143, 22);
            this.textBoxADDRESS.TabIndex = 27;
            // 
            // DOBtimer
            // 
            this.DOBtimer.Location = new System.Drawing.Point(531, 287);
            this.DOBtimer.Name = "DOBtimer";
            this.DOBtimer.Size = new System.Drawing.Size(266, 22);
            this.DOBtimer.TabIndex = 28;
            // 
            // comboBoxcountry
            // 
            this.comboBoxcountry.FormattingEnabled = true;
            this.comboBoxcountry.Items.AddRange(new object[] {
            "United States ",
            "Canada"});
            this.comboBoxcountry.Location = new System.Drawing.Point(612, 243);
            this.comboBoxcountry.Name = "comboBoxcountry";
            this.comboBoxcountry.Size = new System.Drawing.Size(176, 24);
            this.comboBoxcountry.TabIndex = 29;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Gold;
            this.btn_Submit.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(588, 321);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(170, 64);
            this.btn_Submit.TabIndex = 31;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.Gold;
            this.button_1.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(588, 391);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(170, 47);
            this.button_1.TabIndex = 32;
            this.button_1.Text = "Log Out";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBoxcountry);
            this.Controls.Add(this.DOBtimer);
            this.Controls.Add(this.textBoxADDRESS);
            this.Controls.Add(this.textBoxFIRSTNAME);
            this.Controls.Add(this.textBoxPHONE);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.textBoxLASTNAME);
            this.Controls.Add(this.textBoxACCNUM);
            this.Controls.Add(labelPIN);
            this.Controls.Add(labelBALANCE);
            this.Controls.Add(labelDOB);
            this.Controls.Add(labelLN);
            this.Controls.Add(labelADRESS);
            this.Controls.Add(labelFNAME);
            this.Controls.Add(labelPHONE);
            this.Controls.Add(label_AN);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxACCNUM;
        private System.Windows.Forms.TextBox textBoxLASTNAME;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.TextBox textBoxPHONE;
        private System.Windows.Forms.TextBox textBoxFIRSTNAME;
        private System.Windows.Forms.TextBox textBoxADDRESS;
        private System.Windows.Forms.DateTimePicker DOBtimer;
        private System.Windows.Forms.ComboBox comboBoxcountry;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button button_1;
    }
}