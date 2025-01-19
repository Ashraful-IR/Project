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
        private Dashboard _dashboard; // Reference to Dashboard

        public AboutUs(Dashboard dashboard) // Accept Dashboard reference
        {
            InitializeComponent();
            _dashboard = dashboard; // Store the Dashboard reference
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
            // Implement navigation to the home page if required
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void MissionB_Click(object sender, EventArgs e)
        {
            // Load Mission form into Dashboard's panel
            Mission mission = new Mission();
            _dashboard.AddControls(mission); // Use Dashboard's method to load the form
        }

        private void PurposeB_Click(object sender, EventArgs e)
        {
            // You can similarly load the Purpose form if required
            Purpose purpose = new Purpose();
            _dashboard.AddControls(purpose);
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            // Implement back navigation if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: Handle events for the PictureBox
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            // Handle any initialization logic when AboutUs loads
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle paint events for the panel if necessary
        }

        private void ContactB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HotLine Number: 00995687");
        }
    }
}
