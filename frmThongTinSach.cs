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
    public partial class frmThongTinSach : Form
    {
        bool bAddNew = false;
        Book book;
        frmQuanLySach frmQuanLySach;
        public frmThongTinSach()
        {
            InitializeComponent();
        }
       
       
        public frmThongTinSach(frmQuanLySach frmQuanLySach, bool status)
        {
            InitializeComponent();
            bAddNew = status;


            this.gb_TTS.Text = "Thêm sách";
            this.frmQuanLySach = frmQuanLySach;
        }

        public frmThongTinSach(frmQuanLySach frmQuanLySach, bool status, Book book)
        {
            InitializeComponent();
            bAddNew = status;
            this.gb_TTS.Text = "Sửa sách";
            this.book = new Book()
            {
                Id = book.Id,
                Name = book.Name,
                AuthorId = book.AuthorId,
                PublicationDate = book.PublicationDate,
                CategoryId = book.CategoryId,
            };
            this.frmQuanLySach = frmQuanLySach;
        }

        public void ThemSach()
        {
            if ( string.IsNullOrEmpty(tb_Name.Text) || string.IsNullOrEmpty(tb_AuthorID.Text) || string.IsNullOrEmpty(tb_PublicationDate.Text) || string.IsNullOrEmpty(tb_CategoryID.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
                try
                {
                    using (SqlConnection connection = new SqlConnection(strConnect))
                    {
                        connection.Open();

                        // Lấy thông tin từ các TextBox
                        //int Id = int.Parse(tb_ID.Text);
                        string Name = tb_Name.Text;
                        int AUthorID = int.Parse(tb_AuthorID.Text);
                        string PublicationDate = tb_PublicationDate.Text;
                        int CategoryID = int.Parse(tb_CategoryID.Text);

                        // Câu lệnh SQL để thêm sach
                        string query = "INSERT INTO Book (  Name, AUthorId, PublicationDate, CategoryID) VALUES ( @Name, @AUthorID, @PublicationDate, @CategoryID)";


                        SqlCommand command = new SqlCommand(query, connection);
                        //command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@AUthorID", AUthorID);
                        command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
                        command.Parameters.AddWithValue("@CategoryID", CategoryID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            frmQuanLySach.LoadBook();
                            MessageBox.Show("Sách đã được thêm vào cơ sở dữ liệu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm Sách: " + ex.Message);
                }
            }

        }

        public void SuaThongTinSach()
        {
            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnect))
                {
                    connection.Open();

                    // Lấy thông tin từ các TextBox
                    int Id = int.Parse(tb_ID.Text);
                    string Name = tb_Name.Text;
                    int AUthorID = int.Parse(tb_AuthorID.Text);
                    string PublicationDate = tb_PublicationDate.Text;
                    int CategoryID = int.Parse(tb_CategoryID.Text);

                    // Câu lệnh SQL để cập nhật thông tin nhân viên
                    string query = "UPDATE Book SET  Name = @Name, AUthorID = @AUthorID, PublicationDate = @PublicationDate, CategoryID = @CategoryID WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@AUthorID", AUthorID);
                    command.Parameters.AddWithValue("@PublicationDate", PublicationDate);
                    command.Parameters.AddWithValue("@CategoryID", CategoryID);
                    
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin sách đã được cập nhật thành công.");
                        frmQuanLySach.LoadBook();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sách ID tương ứng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin sách: " + ex.Message);
            }
        }

        

       
       

        private void frmThongTinSach_Load(object sender, EventArgs e)
        {
            if (bAddNew)
            {

            }
            else
            {
                tb_ID.Text = book.Id.ToString();               
                tb_AuthorID.Text = book.AuthorId.ToString();
                tb_Name.Text = book.Name.ToString();
                tb_PublicationDate.Text = book.PublicationDate.ToString();
                tb_CategoryID.Text = book.CategoryId.ToString();
            }
        }

        private void bt_XacNhan_Click_1(object sender, EventArgs e)
        {
            if (bAddNew)
            {
                ThemSach();
            }
            else
            {
                SuaThongTinSach();
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
