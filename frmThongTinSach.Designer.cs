namespace ASM_2_DDD
{
    partial class frmThongTinSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_AuthorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_PublicationDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CategoryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_TTS = new System.Windows.Forms.GroupBox();
            this.bt_XacNhan = new System.Windows.Forms.Button();
            this.bt_Close = new System.Windows.Forms.Button();
            this.gb_TTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(117, 53);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(128, 22);
            this.tb_ID.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(117, 101);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(128, 22);
            this.tb_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tb_AuthorID
            // 
            this.tb_AuthorID.Location = new System.Drawing.Point(117, 155);
            this.tb_AuthorID.Name = "tb_AuthorID";
            this.tb_AuthorID.Size = new System.Drawing.Size(128, 22);
            this.tb_AuthorID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "AuthorID";
            // 
            // tb_PublicationDate
            // 
            this.tb_PublicationDate.Location = new System.Drawing.Point(392, 50);
            this.tb_PublicationDate.Name = "tb_PublicationDate";
            this.tb_PublicationDate.Size = new System.Drawing.Size(128, 22);
            this.tb_PublicationDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "PublicationDate";
            // 
            // tb_CategoryID
            // 
            this.tb_CategoryID.Location = new System.Drawing.Point(392, 101);
            this.tb_CategoryID.Name = "tb_CategoryID";
            this.tb_CategoryID.Size = new System.Drawing.Size(128, 22);
            this.tb_CategoryID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "CategoryID";
            // 
            // gb_TTS
            // 
            this.gb_TTS.Controls.Add(this.tb_CategoryID);
            this.gb_TTS.Controls.Add(this.label5);
            this.gb_TTS.Controls.Add(this.tb_PublicationDate);
            this.gb_TTS.Controls.Add(this.label4);
            this.gb_TTS.Controls.Add(this.tb_AuthorID);
            this.gb_TTS.Controls.Add(this.label3);
            this.gb_TTS.Controls.Add(this.tb_Name);
            this.gb_TTS.Controls.Add(this.label2);
            this.gb_TTS.Controls.Add(this.tb_ID);
            this.gb_TTS.Controls.Add(this.label1);
            this.gb_TTS.Location = new System.Drawing.Point(120, 42);
            this.gb_TTS.Name = "gb_TTS";
            this.gb_TTS.Size = new System.Drawing.Size(573, 252);
            this.gb_TTS.TabIndex = 10;
            this.gb_TTS.TabStop = false;
            this.gb_TTS.Text = "gb_TTS";
            // 
            // bt_XacNhan
            // 
            this.bt_XacNhan.Location = new System.Drawing.Point(120, 348);
            this.bt_XacNhan.Name = "bt_XacNhan";
            this.bt_XacNhan.Size = new System.Drawing.Size(95, 41);
            this.bt_XacNhan.TabIndex = 11;
            this.bt_XacNhan.Text = "Save";
            this.bt_XacNhan.UseVisualStyleBackColor = true;
            this.bt_XacNhan.Click += new System.EventHandler(this.bt_XacNhan_Click_1);
            // 
            // bt_Close
            // 
            this.bt_Close.Location = new System.Drawing.Point(598, 348);
            this.bt_Close.Name = "bt_Close";
            this.bt_Close.Size = new System.Drawing.Size(95, 41);
            this.bt_Close.TabIndex = 12;
            this.bt_Close.Text = "Close";
            this.bt_Close.UseVisualStyleBackColor = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_Close_Click);
            // 
            // frmThongTinSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Close);
            this.Controls.Add(this.bt_XacNhan);
            this.Controls.Add(this.gb_TTS);
            this.Name = "frmThongTinSach";
            this.Text = "frmThongTinSach";
            this.Load += new System.EventHandler(this.frmThongTinSach_Load);
            this.gb_TTS.ResumeLayout(false);
            this.gb_TTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_AuthorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_PublicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CategoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_TTS;
        private System.Windows.Forms.Button bt_XacNhan;
        private System.Windows.Forms.Button bt_Close;
    }
}