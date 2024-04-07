using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_2_DDD
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        bool checkAdmin ;

        public MDIParent1()
        {
            InitializeComponent();
        }


        public MDIParent1(bool checkAdmin)
        {
            InitializeComponent();
            this.checkAdmin = checkAdmin;
        }




        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if(checkAdmin)
            {
                frmQuanLySach frmQLS = new frmQuanLySach();
                frmQLS.Show();
            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
