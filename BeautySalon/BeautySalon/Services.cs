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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            new SearchResults().Show();
            this.Hide();
        }
    }
}
