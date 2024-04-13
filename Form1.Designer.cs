namespace ASM_2_DDD
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBname = new System.Windows.Forms.TextBox();
            this.TBpasswork = new System.Windows.Forms.TextBox();
            this.BTconfirm = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Login = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(144, 36);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(165, 22);
            this.TBname.TabIndex = 2;
            // 
            // TBpasswork
            // 
            this.TBpasswork.Location = new System.Drawing.Point(144, 117);
            this.TBpasswork.Name = "TBpasswork";
            this.TBpasswork.PasswordChar = '*';
            this.TBpasswork.Size = new System.Drawing.Size(165, 22);
            this.TBpasswork.TabIndex = 3;
            this.TBpasswork.TextChanged += new System.EventHandler(this.TBpasswork_TextChanged);
            // 
            // BTconfirm
            // 
            this.BTconfirm.Location = new System.Drawing.Point(171, 186);
            this.BTconfirm.Name = "BTconfirm";
            this.BTconfirm.Size = new System.Drawing.Size(105, 28);
            this.BTconfirm.TabIndex = 4;
            this.BTconfirm.Text = "Login";
            this.BTconfirm.UseVisualStyleBackColor = true;
            this.BTconfirm.Click += new System.EventHandler(this.BTconfirm_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASM_2_DDD.Properties.Resources._153151cac_loai_hinh_thu_vien;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.BTconfirm);
            this.Login.Controls.Add(this.TBpasswork);
            this.Login.Controls.Add(this.TBname);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.label1);
            this.Login.Location = new System.Drawing.Point(204, 137);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(440, 265);
            this.Login.TabIndex = 7;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.TextBox TBpasswork;
        private System.Windows.Forms.Button BTconfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Login;
    }
}

