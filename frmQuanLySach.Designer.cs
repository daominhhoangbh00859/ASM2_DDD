namespace ASM_2_DDD
{
    partial class frmQuanLySach
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBt = new System.Windows.Forms.Button();
            this.authorTb = new System.Windows.Forms.TextBox();
            this.bookTitleTb = new System.Windows.Forms.TextBox();
            this.dgv_frmQuanLySach = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.categoryCb = new System.Windows.Forms.ComboBox();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.SearchBt = new System.Windows.Forms.Button();
            this.AddBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frmQuanLySach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book";
            // 
            // EditBt
            // 
            this.EditBt.Location = new System.Drawing.Point(189, 166);
            this.EditBt.Name = "EditBt";
            this.EditBt.Size = new System.Drawing.Size(80, 41);
            this.EditBt.TabIndex = 17;
            this.EditBt.Text = "Edit";
            this.EditBt.UseVisualStyleBackColor = true;
            this.EditBt.Click += new System.EventHandler(this.EditBt_Click);
            // 
            // authorTb
            // 
            this.authorTb.Location = new System.Drawing.Point(413, 18);
            this.authorTb.Name = "authorTb";
            this.authorTb.Size = new System.Drawing.Size(102, 22);
            this.authorTb.TabIndex = 16;
            // 
            // bookTitleTb
            // 
            this.bookTitleTb.Location = new System.Drawing.Point(167, 18);
            this.bookTitleTb.Name = "bookTitleTb";
            this.bookTitleTb.Size = new System.Drawing.Size(102, 22);
            this.bookTitleTb.TabIndex = 15;
            // 
            // dgv_frmQuanLySach
            // 
            this.dgv_frmQuanLySach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_frmQuanLySach.Location = new System.Drawing.Point(-4, 231);
            this.dgv_frmQuanLySach.Name = "dgv_frmQuanLySach";
            this.dgv_frmQuanLySach.RowHeadersWidth = 51;
            this.dgv_frmQuanLySach.RowTemplate.Height = 24;
            this.dgv_frmQuanLySach.Size = new System.Drawing.Size(803, 207);
            this.dgv_frmQuanLySach.TabIndex = 14;
            this.dgv_frmQuanLySach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_frmQuanLySach_CellContentClick);
            this.dgv_frmQuanLySach.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 41);
            this.button2.TabIndex = 25;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // categoryCb
            // 
            this.categoryCb.FormattingEnabled = true;
            this.categoryCb.Location = new System.Drawing.Point(671, 16);
            this.categoryCb.Name = "categoryCb";
            this.categoryCb.Size = new System.Drawing.Size(106, 24);
            this.categoryCb.TabIndex = 21;
            // 
            // DeleteBt
            // 
            this.DeleteBt.Location = new System.Drawing.Point(343, 166);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(80, 41);
            this.DeleteBt.TabIndex = 26;
            this.DeleteBt.Text = "Delete";
            this.DeleteBt.UseVisualStyleBackColor = true;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // SearchBt
            // 
            this.SearchBt.Location = new System.Drawing.Point(498, 166);
            this.SearchBt.Name = "SearchBt";
            this.SearchBt.Size = new System.Drawing.Size(80, 41);
            this.SearchBt.TabIndex = 27;
            this.SearchBt.Text = "Search";
            this.SearchBt.UseVisualStyleBackColor = true;
            this.SearchBt.Click += new System.EventHandler(this.SearchBt_Click);
            // 
            // AddBt
            // 
            this.AddBt.Location = new System.Drawing.Point(57, 166);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(80, 41);
            this.AddBt.TabIndex = 28;
            this.AddBt.Text = "Add";
            this.AddBt.UseVisualStyleBackColor = true;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ASM_2_DDD.Properties.Resources._206ab01e_3009_4634_917a_840214149fc5;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBt);
            this.Controls.Add(this.SearchBt);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditBt);
            this.Controls.Add(this.authorTb);
            this.Controls.Add(this.bookTitleTb);
            this.Controls.Add(this.dgv_frmQuanLySach);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.categoryCb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmQuanLySach";
            this.Text = "frmQuanLySach";
            this.Load += new System.EventHandler(this.frmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_frmQuanLySach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBt;
        private System.Windows.Forms.TextBox authorTb;
        private System.Windows.Forms.TextBox bookTitleTb;
        private System.Windows.Forms.DataGridView dgv_frmQuanLySach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox categoryCb;
        private System.Windows.Forms.Button DeleteBt;
        private System.Windows.Forms.Button SearchBt;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}