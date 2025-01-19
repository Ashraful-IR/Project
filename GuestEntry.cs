using Guna.UI2.WinForms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sub_City_Management
{
    public partial class GuestEntry : Form
    {
        private Dashboard _dashboard; // Reference to Dashboard

        public GuestEntry(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard; // Store the Dashboard reference
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
        }

        private void GuestEntry_Load(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Ensure that the checkbox is checked before submitting
            if (!CheckBox.Checked)
            {
                MessageBox.Show("Please check the checkbox to submit the form.");
                return; // Prevent submission if checkbox is not checked
            }

            // SQL connection and insert operation to store data into GuestEntry table
            SqlConnection con = new SqlConnection("Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO GuestEntry ([Host Name], [Number Of Guest], [Relation With Guest], " +
                "[Purpose Of Visit], [Guest's Name], [Guest Details], [Arrival Time], [Departure Time], [Any Vehicle]) " +
                "VALUES (@HostName, @NumberOfGuest, @RelationWithGuest, @PurposeOfVisit, @GuestsName, @GuestDetails, @ArrivalTime, @DepartureTime, @AnyVehicle)", con);

            // Use corrected parameter names
            cmd.Parameters.AddWithValue("@HostName", HName.Text);
            cmd.Parameters.AddWithValue("@NumberOfGuest", int.Parse(NGuest.Text));
            cmd.Parameters.AddWithValue("@RelationWithGuest", RHost.Text);
            cmd.Parameters.AddWithValue("@PurposeOfVisit", PVisit.Text);
            cmd.Parameters.AddWithValue("@GuestsName", GNames.Text);
            cmd.Parameters.AddWithValue("@GuestDetails", GDetail.Text);
            cmd.Parameters.AddWithValue("@ArrivalTime", Arrival.Text);
            cmd.Parameters.AddWithValue("@DepartureTime", Departure.Text);
            cmd.Parameters.AddWithValue("@AnyVehicle", Vehichle.Text);

            // Execute the query
            cmd.ExecuteNonQuery();
            con.Close();

            // Display success message
            MessageBox.Show("SUBMITTED");

            // Navigate to GESubmit page (if necessary)
            // _dashboard.AddControls(new GESubmit());
        }

        // Enable or disable the submit button based on checkbox state
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is checked, enable the submit button, else disable it
            Submit.Enabled = CheckBox.Checked;
        }
    }
}
