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
    public partial class Form3 : Form
    {
        User user;
        public Form3()
        {
            InitializeComponent();
        }

        public void LoadUser()
        {
            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            SqlConnection cnn = new SqlConnection(strConnect);
            string command = "SELECT * FROM UserTable";
            SqlCommand myCommand = new SqlCommand(command, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            this.dgv_QuanLyUser.DataSource = dataTable;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            int gender;
            string name = nameTb.Text;
            string email = emailTb.Text;
            string address = addressTb.Text;
            if (!string.IsNullOrEmpty(genderTb.Text))
            {
                gender = int.Parse(genderTb.Text);
            }
               

            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            SqlConnection cnn = new SqlConnection(strConnect);
            
            string command;
            if (!string.IsNullOrEmpty(nameTb.Text) && !string.IsNullOrEmpty(emailTb.Text) && !string.IsNullOrEmpty(addressTb.Text) && !string.IsNullOrEmpty(genderTb.Text))
            {
                command = String.Format("SELECT * FROM UserTable WHERE name like '%{0}%' and email like '%{1}%' and address like  '%{3}%' and gender = {4}", name, email, address, int.Parse(genderTb.Text));
            }
            else if (!string.IsNullOrEmpty(nameTb.Text))
            {
                command = String.Format("SELECT * FROM UserTable WHERE name like '%{0}%'"  , name);
            }
            else if (!string.IsNullOrEmpty(emailTb.Text))
            {
                command = String.Format("SELECT * FROM UserTable WHERE email like '%{0}%'  ", email);
            }
            else if (!string.IsNullOrEmpty(addressTb.Text))
            {
                command = String.Format("SELECT * FROM UserTable WHERE address like '%{0}%'  ", address);
            }
            else if (!string.IsNullOrEmpty(genderTb.Text))
            {
                command = String.Format("SELECT * FROM UserTable WHERE gender = {0}  ", int.Parse(genderTb.Text));
            }
            else
            {
                command = String.Format("SELECT * FROM UserTable" );
            }
            /*if (!isNullBookTitle)
            {

            }*/

            SqlCommand myCommand = new SqlCommand(command, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            this.dgv_QuanLyUser.DataSource = dataTable;
        }

        private void addBt_Click(object sender, EventArgs e)
        {
            themsuanguoidung  themsuanguoidung = new themsuanguoidung(this, true);
            themsuanguoidung.ShowDialog();
        }

        private void dgv_QuanLyUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgv_QuanLyUser.Rows[e.RowIndex];
            this.Text = row.Cells["id"].Value.ToString();
            user = new User(
                int.Parse(row.Cells["id"].Value.ToString()),
                row.Cells["name"].Value.ToString(),
                row.Cells["email"].Value.ToString(),
                row.Cells["password"].Value.ToString(),
                row.Cells["address"].Value.ToString(),
                int.Parse(row.Cells["gender"].Value.ToString()),
                Convert.ToChar(row.Cells["role"].Value.ToString())
             );
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            themsuanguoidung themsuanguoidung = new themsuanguoidung(this, false, user);
            themsuanguoidung.ShowDialog();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nguoi dung này!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                XoaUser();
                LoadUser();
            }
            else
            {

            }
        }

        public void XoaUser()
        {
            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnect))
                {
                    connection.Open();

                    // Câu lệnh SQL để xóa nguoi dung
                    string query = "DELETE FROM UserTable WHERE Id = @Id   ";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", user.Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Nguoi dung đã được xóa khỏi cơ sở dữ liệu.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nguoi dung có ID tương ứng.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nguoi dung: " + ex.Message);
            }
        }
    }
    
}
