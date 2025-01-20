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

            try
            {
                // SQL connection and insert operation to store data into GuestEntry table
                using (SqlConnection con = new SqlConnection("Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;"))
                {
                    con.Open();

                    // Generate a unique guest ID
                    SqlCommand idCmd = new SqlCommand("SELECT MAX(ID) FROM dbo.GuestEntry", con); // Ensure the table name is correct
                    object result = idCmd.ExecuteScalar();
                    int newId = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1; // Start from 1 if no records
                                                                                          // Generate a unique guest ID as an integer
                    string guestId = newId.ToString(); // Use only the numeric ID
                    string formattedGuestId = "GUEST-" + guestId.PadLeft(5, '0'); // Format as GUEST-00123

                    // Insert the guest data into the database, including the guest ID
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO dbo.GuestEntry (ID, [Host Name], [Number Of Guest], [Relation With Host], " +
                        "[Purpose Of Visit], [Guest's Name], [Guest Detail], [Arrival Time], [Departure Time], [Any Vehicle]) " +
                        "VALUES (@GuestID, @HostName, @NumberOfGuest, @RelationWithHost, @PurposeOfVisit, @GuestsName, @GuestDetail, @ArrivalTime, @DepartureTime, @AnyVehicle)", con);

                    cmd.Parameters.AddWithValue("@GuestID", guestId); // Insert formatted guest ID
                    cmd.Parameters.AddWithValue("@HostName", HName.Text);
                    cmd.Parameters.AddWithValue("@NumberOfGuest", int.Parse(NGuest.Text)); // Ensure NGuest.Text is a valid integer
                    cmd.Parameters.AddWithValue("@RelationWithHost", RHost.Text);
                    cmd.Parameters.AddWithValue("@PurposeOfVisit", PVisit.Text);
                    cmd.Parameters.AddWithValue("@GuestsName", GNames.Text);
                    cmd.Parameters.AddWithValue("@GuestDetail", GDetail.Text);
                    cmd.Parameters.AddWithValue("@ArrivalTime", Arrival.Text);
                    cmd.Parameters.AddWithValue("@DepartureTime", Departure.Text);
                    cmd.Parameters.AddWithValue("@AnyVehicle", Vehichle.Text);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Display success message with Guest ID
                    MessageBox.Show($"SUBMITTED\nGuest ID: {guestId}");
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-specific errors
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Handle general errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
