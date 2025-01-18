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
    public partial class Dashboard : Form
    {
        public Dashboard()
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

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddControls(new Complaint());
        }

        private void GEbutton_Click(object sender, EventArgs e)
        {
            AddControls(new GuestEntry());
        }

        private void AUbutton_Click(object sender, EventArgs e)
        {
            AddControls(new AboutUs());
        }

        private void DashB_Click(object sender, EventArgs e)
        {
            //AddControls(new Dashboard());
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            AddControls(new Home());
        }
    }
}
