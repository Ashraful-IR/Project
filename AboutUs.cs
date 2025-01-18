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
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            
            Form4 form4 = new Form4();
            form4.Show();

        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            

        }

        private void MissionB_Click(object sender, EventArgs e)
        {
            Mission mission = new Mission();
            mission.Show();
        }

        private void PurposeB_Click(object sender, EventArgs e)
        {
            Purpose purpose = new Purpose();
            purpose.Show();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
