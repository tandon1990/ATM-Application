namespace atmApplication
{
    partial class ChangePin
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
            System.Windows.Forms.Label YCBRS;
            System.Windows.Forms.Label ANRS;
            System.Windows.Forms.Label labelCP;
            System.Windows.Forms.Label label_NP;
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_change = new System.Windows.Forms.Button();
            this.textBoxNP = new System.Windows.Forms.TextBox();
            this.textBoxCP = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label_AMS = new System.Windows.Forms.Label();
            YCBRS = new System.Windows.Forms.Label();
            ANRS = new System.Windows.Forms.Label();
            labelCP = new System.Windows.Forms.Label();
            label_NP = new System.Windows.Forms.Label();
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
            label_AMS.Location = new System.Drawing.Point(133, 29);
            label_AMS.Name = "label_AMS";
            label_AMS.Size = new System.Drawing.Size(548, 50);
            label_AMS.TabIndex = 2;
            label_AMS.Text = "CHANGE ACCOUNT PIN";
            label_AMS.Click += new System.EventHandler(this.label_AMS_Click);
            // 
            // YCBRS
            // 
            YCBRS.AutoSize = true;
            YCBRS.BackColor = System.Drawing.Color.Transparent;
            YCBRS.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            YCBRS.ForeColor = System.Drawing.Color.Black;
            YCBRS.Location = new System.Drawing.Point(510, 237);
            YCBRS.Name = "YCBRS";
            YCBRS.Size = new System.Drawing.Size(0, 32);
            YCBRS.TabIndex = 21;
            // 
            // ANRS
            // 
            ANRS.AutoSize = true;
            ANRS.BackColor = System.Drawing.Color.Transparent;
            ANRS.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ANRS.ForeColor = System.Drawing.Color.Black;
            ANRS.Location = new System.Drawing.Point(510, 138);
            ANRS.Name = "ANRS";
            ANRS.Size = new System.Drawing.Size(0, 32);
            ANRS.TabIndex = 20;
            // 
            // labelCP
            // 
            labelCP.AutoSize = true;
            labelCP.BackColor = System.Drawing.Color.Transparent;
            labelCP.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelCP.ForeColor = System.Drawing.Color.Black;
            labelCP.Location = new System.Drawing.Point(136, 209);
            labelCP.Name = "labelCP";
            labelCP.Size = new System.Drawing.Size(211, 32);
            labelCP.TabIndex = 19;
            labelCP.Text = "CONFIRM PIN";
            // 
            // label_NP
            // 
            label_NP.AutoSize = true;
            label_NP.BackColor = System.Drawing.Color.Transparent;
            label_NP.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_NP.ForeColor = System.Drawing.Color.Black;
            label_NP.Location = new System.Drawing.Point(208, 138);
            label_NP.Name = "label_NP";
            label_NP.Size = new System.Drawing.Size(139, 32);
            label_NP.TabIndex = 18;
            label_NP.Text = "NEW PIN";
            label_NP.Click += new System.EventHandler(this.label_AN_Click);
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
            this.panel5.TabIndex = 3;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Gold;
            this.btn_change.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change.Location = new System.Drawing.Point(374, 281);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(170, 64);
            this.btn_change.TabIndex = 22;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // textBoxNP
            // 
            this.textBoxNP.Location = new System.Drawing.Point(374, 147);
            this.textBoxNP.Name = "textBoxNP";
            this.textBoxNP.Size = new System.Drawing.Size(170, 22);
            this.textBoxNP.TabIndex = 23;
            // 
            // textBoxCP
            // 
            this.textBoxCP.Location = new System.Drawing.Point(374, 219);
            this.textBoxCP.Name = "textBoxCP";
            this.textBoxCP.Size = new System.Drawing.Size(170, 22);
            this.textBoxCP.TabIndex = 24;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.DimGray;
            this.btn_back.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(609, 374);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(170, 64);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.textBoxCP);
            this.Controls.Add(this.textBoxNP);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(YCBRS);
            this.Controls.Add(ANRS);
            this.Controls.Add(labelCP);
            this.Controls.Add(label_NP);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePin";
            this.Text = "ChangePin";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox textBoxNP;
        private System.Windows.Forms.TextBox textBoxCP;
        private System.Windows.Forms.Button btn_back;
    }
}