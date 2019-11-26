using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class Salon : Form
    {
        public Salon()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            // cancel an appotinment

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            new Services().Show();
            this.Hide();
        }
    }
}
