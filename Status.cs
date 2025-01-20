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
    public partial class Status : Form
    {
        private Panel controlPanel; // Reference to the panel in the Dashboard form

        public Status()
        {
            InitializeComponent();
        }

        public Status(Panel controlPanel)
        {
            InitializeComponent();
            this.controlPanel = controlPanel; // Assign the passed panel reference
        }

        private void SearchB_TextChanged(object sender, EventArgs e)
        {
            // Add search functionality here if needed
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            // Create a new context menu with options
            ContextMenuStrip menu = new ContextMenuStrip();

            // Add "Guest Entry" option
            ToolStripMenuItem guestEntryOption = new ToolStripMenuItem("Guest Entry");
            guestEntryOption.Click += (s, args) => ShowGuestEntryPage();
            menu.Items.Add(guestEntryOption);

            // Add "Add Complaint" option
            ToolStripMenuItem addComplaintOption = new ToolStripMenuItem("Add Complaint");
            addComplaintOption.Click += (s, args) => ShowComplaintPage();
            menu.Items.Add(addComplaintOption);

            // Show the context menu below the AddB button
            menu.Show(AddB, new Point(0, AddB.Height));
        }

        private void ShowGuestEntryPage()
        {
            // Ensure controlPanel is not null
            if (controlPanel != null)
            {
                controlPanel.Controls.Clear(); // Clear the panel
                GuestEntry guestEntryPage = new GuestEntry(controlPanel)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                controlPanel.Controls.Add(guestEntryPage); // Add GuestEntry to the panel
                guestEntryPage.Show(); // Show the GuestEntry page
            }
            else
            {
                MessageBox.Show("Control panel reference is null. Unable to load Guest Entry page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowComplaintPage()
        {
            // Ensure controlPanel is not null
            if (controlPanel != null)
            {
                controlPanel.Controls.Clear(); // Clear the panel
                Complaint complaintPage = new Complaint(controlPanel)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true
                };
                controlPanel.Controls.Add(complaintPage); // Add Complaint to the panel
                complaintPage.Show(); // Show the Complaint page
            }
            else
            {
                MessageBox.Show("Control panel reference is null. Unable to load Complaint page.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Status_Load(object sender, EventArgs e)
        {
            // Any initialization logic if needed
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }

    // GuestEntry class
    public partial class GuestEntry : Form
    {
        private Panel controlPanel;

        public GuestEntry(Panel controlPanel)
        {
            InitializeComponent();
            this.controlPanel = controlPanel;
            this.Text = "Guest Entry";
        }
    }

    // Complaint class
    public partial class Complaint : Form
    {
        private Panel controlPanel;

        public Complaint(Panel controlPanel)
        {
            InitializeComponent();
            this.controlPanel = controlPanel;
            this.Text = "Add Complaint";
        }
    }
}
