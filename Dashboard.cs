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

        // Method to load forms dynamically into the ControlPanel
        public void AddControls(Form f)
        {
            ControlPanel.Controls.Clear(); // Clear existing controls in the panel
            f.Dock = DockStyle.Fill;       // Make the form fill the panel
            f.TopLevel = false;            // Treat the form as a control
            ControlPanel.Controls.Add(f);  // Add the form to the panel
            f.Show();                      // Display the form
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Handle panel paint events if needed
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
            // Open the AboutUs form and pass this Dashboard instance
            AddControls(new AboutUs(this));
        }

        private void DashB_Click(object sender, EventArgs e)
        {
            // If needed, handle Dashboard navigation
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Navigate to login screen
            form1.Show();
            this.Close(); // Close the current form
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            /*AddControls(new Home());
            Form1 form1 =new Form1();
            form1.Show();
            */
            Form1 form1 = new Form1(); // Navigate to login screen
            form1.Show();
            //this.Close(); // Close the current form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void StatusB_Click(object sender, EventArgs e)
        {
            AddControls(new Status());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Handle panel paint events
        }

        private void ForwardB_Click(object sender, EventArgs e)
        {

        }
    }
}
