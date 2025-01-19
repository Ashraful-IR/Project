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

        public void AddControls(Form f)
        {
            ControlPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlPanel.Controls.Add(f);
            f.Show();

        }
        private void HomeB_Click(object sender, EventArgs e)
        {
            
            

        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            

        }

        private void MissionB_Click(object sender, EventArgs e)
        {
            //AddControls(new Mission());
        }

        private void PurposeB_Click(object sender, EventArgs e)
        {
            //AddControls(new Purpose());
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
