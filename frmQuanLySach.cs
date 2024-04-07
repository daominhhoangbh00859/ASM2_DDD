using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2_DDD
{
    public partial class frmQuanLySach : Form
    {
        Book  book;
        
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        public void loadCategory()
        {
            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            SqlConnection cnn = new SqlConnection(strConnect);
            string command = "SELECT * FROM Category";
            SqlCommand myCommand = new SqlCommand(command, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            this.categoryCb.DataSource = dataTable;
            this.categoryCb.DisplayMember = "name";
        }

        public void LoadBook()
        {
            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            SqlConnection cnn = new SqlConnection(strConnect);
            string command = "SELECT * FROM Book";
            SqlCommand myCommand = new SqlCommand(command, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            this.dgv_frmQuanLySach.DataSource = dataTable;
        }


        private void SearchBt_Click(object sender, EventArgs e)
        {
            string booktile = bookTitleTb.Text;
            string author = authorTb.Text;
            var selectedRow = this.categoryCb.SelectedItem as DataRowView;
            var cateID = selectedRow["id"];

            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            SqlConnection cnn = new SqlConnection(strConnect);
            bool isNullBookTitle = string.IsNullOrEmpty(booktile);
            bool isNullAuthor = string.IsNullOrEmpty(author);

            Console.WriteLine(this.categoryCb.SelectedItem.ToString());
            string command;
            if (!string.IsNullOrEmpty(bookTitleTb.Text) && !string.IsNullOrEmpty(authorTb.Text) )
            {
                command = String.Format("SELECT * FROM Book, Author WHERE Book.name like '%{0}%' and Author.name like '%{1}%' and Book.categoryID = {2}", booktile, author, cateID);
            }
            else if(!string.IsNullOrEmpty(bookTitleTb.Text))
            {
                command = String.Format("SELECT * FROM Book WHERE Book.name like '%{0}%'  and Book.categoryID = {1}", booktile,  cateID);
            }
            else if(!string.IsNullOrEmpty(authorTb.Text))
            {
                command = String.Format("SELECT * FROM Book, Author  WHERE Author.name like '%{0}%'  and Book.categoryID = {1}", author, cateID);
            }
            else
            {
                command = String.Format("SELECT * FROM Book WHERE  categoryID = {0}", cateID);
            }
            /*if (!isNullBookTitle)
            {

            }*/

            SqlCommand myCommand = new SqlCommand(command, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            this.dgv_frmQuanLySach.DataSource = dataTable;
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            loadCategory(); 
            LoadBook();
        }
         
        private void EditBt_Click(object sender, EventArgs e)
        {
            frmThongTinSach frmThongTinSach = new frmThongTinSach(this, false, book);
            frmThongTinSach.ShowDialog();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_frmQuanLySach.Rows[e.RowIndex];
            this.Text = row.Cells["id"].Value.ToString();
            book = new Book(
                int.Parse(row.Cells["id"].Value.ToString()),
                row.Cells["name"].Value.ToString(),
                int.Parse(row.Cells["authorId"].Value.ToString()),
                row.Cells["publicationDate"].Value.ToString(),
               int.Parse(row.Cells["categoryId"].Value.ToString())
             );
        }

        private void AddBt_Click(object sender, EventArgs e)
        {
            frmThongTinSach frmThongTinSach = new frmThongTinSach(this, true);
            frmThongTinSach.ShowDialog();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa sach này!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                XoaSach();
                LoadBook();
            }
            else
            {

            }
        }

       

        public void XoaSach()
        {
            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnect))
                {
                    connection.Open();

                    // Câu lệnh SQL để xóa sach
                    string query = "DELETE FROM Book WHERE Id = @Id   ";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", book.Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sach đã được xóa khỏi cơ sở dữ liệu.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sach có ID tương ứng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sach: " + ex.Message);
            }
        }

    }
}
