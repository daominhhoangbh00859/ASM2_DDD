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
    public partial class Form1 : Form
    {
        bool checkAdmin;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void BTconfirm_Click_1(object sender, EventArgs e)
        {
            string username = TBname.Text;
            string password = TBpasswork.Text;

            if (CheckUsernamePassword(username, password))
            {
                if (checkAdmin)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    MDIParent1 mdi = new MDIParent1(checkAdmin);
                    mdi.Show();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    // Hiển thị Form2 nếu không phải admin
                    Form2 form2 = new Form2();
                    form2.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!");
            }
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private bool CheckUsernamePassword(string username, string password)
        {
            string connectionString = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            string strCommand = String.Format("SELECT *FROM UserTable " + "WHERE email = N'{0}' " + "AND password = N'{1}'", username, password);
            
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand myCommand = new SqlCommand(strCommand, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataSet dataTable = new DataSet();
            da.Fill(dataTable, "ABC");
            if (dataTable.Tables[0].Rows.Count > 0)
            {
                string role = dataTable.Tables["ABC"].Rows[0]["role"].ToString();
                if (role == "A" || role == "a")
                {
                    
                    checkAdmin = true;

                }
                else 
                {
                    checkAdmin = false ;
                    
                }
                return true;
            }
            else { return false; }
            
        }

        private void TBpasswork_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
