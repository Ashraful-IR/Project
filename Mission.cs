using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub_City_Management
{
    public partial class Mission : Form
    {
        public Mission()
        {
            InitializeComponent();
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
           
           

        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            

        }

        private void Backb_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.Show();
        }

        private void ForwardB_Click(object sender, EventArgs e)
        {
            Purpose purpose = new Purpose();
            purpose.Show();
        }
    }
}
