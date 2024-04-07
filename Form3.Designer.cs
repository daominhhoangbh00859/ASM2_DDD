namespace ASM_2_DDD
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.genderTb = new System.Windows.Forms.TextBox();
            this.searchBt = new System.Windows.Forms.Button();
            this.dgv_QuanLyUser = new System.Windows.Forms.DataGridView();
            this.closeBt = new System.Windows.Forms.Button();
            this.addBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditBt = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(131, 41);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(163, 22);
            this.nameTb.TabIndex = 4;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(131, 136);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(163, 22);
            this.emailTb.TabIndex = 5;
            // 
            // addressTb
            // 
            this.addressTb.Location = new System.Drawing.Point(586, 41);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(163, 22);
            this.addressTb.TabIndex = 6;
            // 
            // genderTb
            // 
            this.genderTb.Location = new System.Drawing.Point(586, 139);
            this.genderTb.Name = "genderTb";
            this.genderTb.Size = new System.Drawing.Size(163, 22);
            this.genderTb.TabIndex = 7;
            // 
            // searchBt
            // 
            this.searchBt.Location = new System.Drawing.Point(32, 195);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(75, 30);
            this.searchBt.TabIndex = 8;
            this.searchBt.Text = "Search";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // dgv_QuanLyUser
            // 
            this.dgv_QuanLyUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuanLyUser.Location = new System.Drawing.Point(0, 246);
            this.dgv_QuanLyUser.Name = "dgv_QuanLyUser";
            this.dgv_QuanLyUser.RowHeadersWidth = 51;
            this.dgv_QuanLyUser.RowTemplate.Height = 24;
            this.dgv_QuanLyUser.Size = new System.Drawing.Size(799, 205);
            this.dgv_QuanLyUser.TabIndex = 10;
            this.dgv_QuanLyUser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuanLyUser_RowEnter);
            // 
            // closeBt
            // 
            this.closeBt.Location = new System.Drawing.Point(674, 195);
            this.closeBt.Name = "closeBt";
            this.closeBt.Size = new System.Drawing.Size(75, 30);
            this.closeBt.TabIndex = 12;
            this.closeBt.Text = "Close";
            this.closeBt.UseVisualStyleBackColor = true;
            // 
            // addBt
            // 
            this.addBt.Location = new System.Drawing.Point(185, 195);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(75, 30);
            this.addBt.TabIndex = 13;
            this.addBt.Text = "Add";
            this.addBt.UseVisualStyleBackColor = true;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASM_2_DDD.Properties.Resources.s;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EditBt
            // 
            this.EditBt.Location = new System.Drawing.Point(329, 195);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(75, 30);
            this.EditBt.TabIndex = 14;
            this.EditBt.Text = "Edit";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(459, 195);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(75, 30);
            this.DeleteBt.TabIndex = 15;
            this.DeleteBt.Text = "Delete";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.addBt);
            this.Controls.Add(this.closeBt);
            this.Controls.Add(this.dgv_QuanLyUser);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.genderTb);
            this.Controls.Add(this.addressTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuanLyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox genderTb;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.DataGridView dgv_QuanLyUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeBt;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.Button DeleteBt;
    }
}