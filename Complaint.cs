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
            // Home button action (if needed)
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            // Handle back button click if needed
        }

        private void Complaint_Load(object sender, EventArgs e)
        {
            // Handle form load logic if needed
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Ensure that the checkbox is checked before submitting
            if (!CheckBox.Checked)
            {
                MessageBox.Show("Please check the checkbox to submit the form.");
                return; // Prevent submission if checkbox is not checked
            }

            // SQL connection and insert operation to store data into Complaint table
            SqlConnection con = new SqlConnection("Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;");
            con.Open();

            // Correct SQL query to insert the complaint data
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Complait ([Full Name], [Email], [Phone Number], [Subject], [Address], [Location of the issue], [Description], [Complaint Type], [Urgenncy Level], [Date & Time]) " +
                "VALUES (@FullName, @Email, @PhoneNumber, @Subject, @Address, @Location, @Description, @ComplaintType, @UrgenncyLevel, @DateTime)", con);

            // Map values from the form controls to the SQL parameters
            cmd.Parameters.AddWithValue("@FullName", FullName.Text); // Assuming FullName is a TextBox
            cmd.Parameters.AddWithValue("@Email", Email.Text); // Assuming Email is a TextBox
            cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(PhoneNumber.Text)); // Assuming PhoneNumber is a TextBox
            cmd.Parameters.AddWithValue("@Subject", Subject.Text); // Assuming Subject is a TextBox
            cmd.Parameters.AddWithValue("@Address", Address.Text); // Assuming Address is a TextBox
            cmd.Parameters.AddWithValue("@Location", Location.Text); // Assuming Location is a TextBox
            cmd.Parameters.AddWithValue("@Description", Description.Text); // Assuming Description is a TextBox
            cmd.Parameters.AddWithValue("@ComplaintType", ComplaintType.Text); // Assuming ComplaintType is a TextBox or ComboBox
            cmd.Parameters.AddWithValue("@UrgenncyLevel", UrgencyLevel.Text); // Assuming UrgencyLevel is a ComboBox or TextBox
            cmd.Parameters.AddWithValue("@DateTime", DateTime.Text); // Current date and time for DateTime field

            // Execute the query
            cmd.ExecuteNonQuery();
            con.Close();

            // Display success message
            MessageBox.Show("Complaint Submitted Successfully!");
        }

        // Enable or disable the submit button based on checkbox state
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is checked, enable the submit button; else, disable it
            guna2Button1.Enabled = CheckBox.Checked;
        }
    }
}
