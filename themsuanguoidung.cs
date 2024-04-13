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
    public partial class themsuanguoidung : Form
    {
        bool bAddNew = false;
        User user;
        Form3 form3;
        public themsuanguoidung()
        {
            InitializeComponent();
        }

        public themsuanguoidung(Form3 form3, bool status)
        {
            InitializeComponent();
            bAddNew = status;


            this.gb_TTS.Text = "Thêm sách";
            this.form3 = form3;
        }

        public themsuanguoidung(Form3 form3, bool status, User user)
        {
            InitializeComponent();
            bAddNew = status;
            this.gb_TTS.Text = "Sửa sách";
            this.user = new User()
            {
                Id = user.Id,
                Name = user.Name,
                Address = user.Address,
                Email = user.Email,
                Role = user.Role,
                Gender = user.Gender,
                Password = user.Password,
            };
            this.form3 = form3;
        }

        public void ThemNguoiDung()
        {
            if (string.IsNullOrEmpty(tb_Name.Text) || string.IsNullOrEmpty(tb_Email.Text) || string.IsNullOrEmpty(tb_Gender.Text) || string.IsNullOrEmpty(tb_Role.Text) || string.IsNullOrEmpty(tb_Address.Text) || string.IsNullOrEmpty(tbPassword.Text))
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
                        string Email = tb_Email.Text;
                        string Address = tb_Address.Text;
                        string Password = tbPassword.Text;
                        int Gender = int.Parse(tb_Gender.Text);
                        char Role = Convert.ToChar(tb_Role.Text);

                        // Câu lệnh SQL để thêm sach
                        string query = "INSERT INTO UserTable (  Name, Email, Address, Password, Gender, Role) VALUES ( @Name, @Email, @Address, @Password, @Gender, @Role)";


                        SqlCommand command = new SqlCommand(query, connection);
                        //command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Role", Role);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            form3.LoadUser();
                            MessageBox.Show("Nguoi dung đã được thêm vào cơ sở dữ liệu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nguoi dung: " + ex.Message);
                }
            }

        }

        public void SuaThongTinNguoiDung()
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
                    string Email = tb_Email.Text;
                    string Address = tb_Address.Text;
                    string Password = tbPassword.Text;
                    int Gender = int.Parse(tb_Gender.Text);
                    char Role = Convert.ToChar(tb_Role.Text);

                    // Câu lệnh SQL để cập nhật thông tin nhân viên
                    string query = "UPDATE UserTable SET  Name = @Name, Email = @Email, Address = @Address, Password = @Password, Gender = @Gender, Role = @Role WHERE Id = @Id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Role", Role);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin người dùng đã được cập nhật thành công.");
                        form3.LoadUser();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy người dùng ID tương ứng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin người dùng: " + ex.Message);
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (bAddNew)
            {
                ThemNguoiDung();
            }
            else
            {
                SuaThongTinNguoiDung();
            }
        }

        private void themsuanguoidung_Load(object sender, EventArgs e)
        {
            if (bAddNew)
            {

            }
            else
            {
                tb_ID.Text = user.Id.ToString();
                tb_Address.Text = user.Address.ToString();
                tb_Name.Text = user.Name.ToString();
                tbPassword.Text = user.Password.ToString();
                tb_Gender.Text = user.Gender.ToString();
                tb_Role.Text = user.Role.ToString();
                tb_Email.Text = user.Email.ToString();
            }
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
