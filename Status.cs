using System;
using System.Data.SqlClient;
using System.Drawing;
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
            // Create a new context menu with options based on the input
            ContextMenuStrip menu = new ContextMenuStrip();

            // Check if the entered text is a valid Guest ID or Complaint ID
            string searchText = SearchB.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                // Check if the text is numeric, then offer both options (Guest ID or Complaint ID)
                if (int.TryParse(searchText, out _))
                {
                    ToolStripMenuItem guestEntryOption = new ToolStripMenuItem("Search by Guest ID");
                    guestEntryOption.Click += (s, args) => ShowGuestInfo(searchText);
                    menu.Items.Add(guestEntryOption);

                    ToolStripMenuItem complaintEntryOption = new ToolStripMenuItem("Search by Complaint ID");
                    complaintEntryOption.Click += (s, args) => ShowComplaintInfo(searchText);
                    menu.Items.Add(complaintEntryOption);
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID (Guest ID or Complaint ID).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Show the context menu below the SearchB TextBox
                menu.Show(SearchB, new Point(0, SearchB.Height));
            }
        }

        private void ShowGuestInfo(string guestId)
        {
            // Retrieve guest information from the database
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GuestEntry WHERE ID = @GuestID", con);
                    cmd.Parameters.AddWithValue("@GuestID", guestId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string guestInfo = $"Guest ID: {reader["ID"]}\n" +
                                                   $"Host Name: {reader["Host Name"]}\n" +
                                                   $"Number of Guests: {reader["Number Of Guest"]}\n" +
                                                   $"Relation with Host: {reader["Relation With Host"]}\n" +
                                                   $"Purpose of Visit: {reader["Purpose Of Visit"]}\n" +
                                                   $"Guest's Name: {reader["Guest's Name"]}\n" +
                                                   $"Guest Details: {reader["Guest Detail"]}\n" +
                                                   $"Arrival Time: {reader["Arrival Time"]}\n" +
                                                   $"Departure Time: {reader["Departure Time"]}\n" +
                                                   $"Vehicle: {reader["Any Vehicle"]}";

                                MessageBox.Show(guestInfo, "Guest Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No guest found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for guest information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowComplaintInfo(string complaintId)
        {
            // Retrieve complaint information from the database
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Complaint WHERE ComplaintID = @ComplaintID", con);
                    cmd.Parameters.AddWithValue("@ComplaintID", complaintId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string complaintInfo = $"Complaint ID: {reader["ComplaintID"]}\n" +
                                                      $"Guest ID: {reader["GuestID"]}\n" +
                                                      $"Complaint Description: {reader["Description"]}\n" +
                                                      $"Complaint Status: {reader["Status"]}\n" +
                                                      $"Date of Complaint: {reader["DateOfComplaint"]}";

                                MessageBox.Show(complaintInfo, "Complaint Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No complaint found with the provided ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for complaint information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            // Trigger the search logic based on the ID entered
            string searchText = SearchB.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                if (int.TryParse(searchText, out _))
                {
                    // Show both guest and complaint search options
                    SearchB_TextChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ShowPanel_Paint(object sender, PaintEventArgs e)
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
