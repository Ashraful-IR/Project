using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sub_City_Management
{
    public partial class Complaint : Form
    {
        public Complaint()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Handle button2 click if needed
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            // Navigate to Home
            Form1 homeForm = new Form1();
            homeForm.Show();
            this.Hide();
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            // Navigate back to the previous form
        }

        private void Complaint_Load(object sender, EventArgs e)
        {
            // Initialize form components or load necessary data if needed
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Ensure that the checkbox is checked before submitting
            if (!CheckBox.Checked)
            {
                MessageBox.Show("Please check the checkbox to confirm before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(FullName.Text) ||
                string.IsNullOrWhiteSpace(Email.Text) ||
                string.IsNullOrWhiteSpace(PhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(Subject.Text) ||
                string.IsNullOrWhiteSpace(Address.Text) ||
                string.IsNullOrWhiteSpace(Location.Text) ||
                string.IsNullOrWhiteSpace(Description.Text) ||
                string.IsNullOrWhiteSpace(ComplaintType.Text) ||
                string.IsNullOrWhiteSpace(UrgencyLevel.Text))
            {
                MessageBox.Show("All fields are required. Please fill out all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(PhoneNumber.Text, out _))
            {
                MessageBox.Show("Phone number must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SQL connection and insert operation
                using (SqlConnection con = new SqlConnection("Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;"))
                {
                    con.Open();

                    // Generate a random integer ComplaintID
                    Random random = new Random();
                    int complaintID = random.Next(1, 100000); // Adjust the range as needed

                    // SQL query to insert the complaint data
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Complaintt ([ComplaintID], [Full Name], [Email], [Phone Number], [Subject], [Address], [Location of the issue], [Description], [Complaint Type], [Urgenncy Level], [Date & Time]) " +
                        "VALUES (@ComplaintID, @FullName, @Email, @PhoneNumber, @Subject, @Address, @Location, @Description, @ComplaintType, @UrgenncyLevel, @DateTime)", con);

                    // Map values from the form controls to the SQL parameters
                    cmd.Parameters.AddWithValue("@ComplaintID", complaintID);
                    cmd.Parameters.AddWithValue("@FullName", FullName.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Subject", Subject.Text);
                    cmd.Parameters.AddWithValue("@Address", Address.Text);
                    cmd.Parameters.AddWithValue("@Location", Location.Text);
                    cmd.Parameters.AddWithValue("@Description", Description.Text);
                    cmd.Parameters.AddWithValue("@ComplaintType", ComplaintType.Text);
                    cmd.Parameters.AddWithValue("@UrgenncyLevel", UrgencyLevel.Text);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Text); // Current date and time

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    // Show success message with ComplaintID
                    MessageBox.Show($"Complaint submitted successfully!\nYour Complaint ID is: {complaintID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Optionally clear form fields
                ClearForm();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Enable or disable the submit button based on checkbox state
            guna2Button1.Enabled = CheckBox.Checked;
        }

        private void ClearForm()
        {
            // Clear all input fields after submission
            FullName.Clear();
            Email.Clear();
            PhoneNumber.Clear();
            Subject.Clear();
            Address.Clear();
            Location.Clear();
            Description.Clear();
            ComplaintType.SelectedIndex = -1; // Reset ComboBox if applicable
            UrgencyLevel.SelectedIndex = -1; // Reset ComboBox if applicable
            CheckBox.Checked = false; // Uncheck the checkbox
        }
    }
}
