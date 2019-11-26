using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeautySalon
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string cmdpath = "desktop-7v9kk3l\\sqlexpress.BeautySalon.dbo";
        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection save = new SqlConnection(cmdpath);
            save.Open();
            if (save.State == System.Data.ConnectionState.Open)
            {
                string values = "insert into customer(id,name)values";
            }


        }

        private void firstnmlbl_Click(object sender, EventArgs e)
        {

        }

        private void idlbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
