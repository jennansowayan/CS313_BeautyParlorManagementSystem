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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }



        private void password_Click(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void uName_TextChanged(object sender, EventArgs e)
        {

        }


        public string cmdpath = "desktop-7v9kk3l\\sqlexpress.BeautySalon.dbo";
        private void logInbtn_Click(object sender, EventArgs e)
        {
            new Salon().Show();
            this.Hide();

        }
    }
}
