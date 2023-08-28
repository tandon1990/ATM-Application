namespace atmApplication
{
    partial class MiniStatment
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_withdraw_logout = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label_Diposit = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            label_Diposit.Font = new System.Drawing.Font("Lucida Fax", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_Diposit.ForeColor = System.Drawing.Color.Red;
            label_Diposit.Location = new System.Drawing.Point(136, 36);
            label_Diposit.Name = "label_Diposit";
            label_Diposit.Size = new System.Drawing.Size(515, 50);
            label_Diposit.TabIndex = 2;
            label_Diposit.Text = "ACCOUNT STATMENT";
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
            this.panel6.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 258);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_withdraw_logout
            // 
            this.btn_withdraw_logout.BackColor = System.Drawing.Color.DimGray;
            this.btn_withdraw_logout.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw_logout.Location = new System.Drawing.Point(564, 377);
            this.btn_withdraw_logout.Name = "btn_withdraw_logout";
            this.btn_withdraw_logout.Size = new System.Drawing.Size(170, 64);
            this.btn_withdraw_logout.TabIndex = 40;
            this.btn_withdraw_logout.Text = "Log Out";
            this.btn_withdraw_logout.UseVisualStyleBackColor = false;
            this.btn_withdraw_logout.Click += new System.EventHandler(this.btn_withdraw_logout_Click);
            // 
            // MiniStatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_withdraw_logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniStatment";
            this.Text = "MiniStatment";
            this.Load += new System.EventHandler(this.MiniStatment_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_withdraw_logout;
    }
}