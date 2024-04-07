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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASM_2_DDD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     

        public void loadCategory() {
            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            SqlConnection cnn = new SqlConnection(strConnect);
            string command = "SELECT * FROM Category";
            SqlCommand myCommand = new SqlCommand(command, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            this.cateIdComboB.DataSource = dataTable;
            this.cateIdComboB.DisplayMember = "name";
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
            this.dataGridView1.DataSource = dataTable;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            loadCategory();
            LoadBook();


        }

        
        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search(object sender, EventArgs e)
        {
            string booktile = booktitleTb.Text;
            string author = authorTb.Text;
            var selectedRow = this.cateIdComboB.SelectedItem as DataRowView;
            var cateID = selectedRow["id"];

            string strConnect = System.Configuration.ConfigurationSettings.AppSettings["MyCNN"].ToString();
            SqlConnection cnn = new SqlConnection(strConnect);
            bool isNullBookTitle = string.IsNullOrEmpty(booktile);
            bool isNullAuthor = string.IsNullOrEmpty(author);

            Console.WriteLine(this.cateIdComboB.SelectedItem.ToString());
            string command;
            if (!string.IsNullOrEmpty(booktitleTb.Text) && !string.IsNullOrEmpty(authorTb.Text))
            {
                command = String.Format("SELECT * FROM Book, Author WHERE Book.name like '%{0}%' and Author.name like '%{1}%' and Book.categoryID = {2}", booktile, author, cateID);
            }
            else if (!string.IsNullOrEmpty(booktitleTb.Text))
            {
                command = String.Format("SELECT * FROM Book WHERE Book.name like '%{0}%'  and Book.categoryID = {1}", booktile, cateID);
            }
            else if (!string.IsNullOrEmpty(authorTb.Text))
            {
                command = String.Format("SELECT * FROM Book, Author  WHERE Author.name like '%{0}%'  and Book.categoryID = {1}", author, cateID);
            }
            else
            {
                command = String.Format("SELECT * FROM Book WHERE  categoryID = {0}", cateID);
            }

            SqlCommand myCommand = new SqlCommand(command, cnn);
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            this.dataGridView1.DataSource = dataTable;
        }
    }

 } 


