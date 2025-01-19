using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Sub_City_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic here
        }

        private void SignUpL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the SignUp form
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void SignInB_Click(object sender, EventArgs e)
        {
            // Optional: Handle SignIn button click here if needed
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes in the EmailBox here if needed
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click events here if needed
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Get the email and password entered by the user
            string email = EmailBox.Text.Trim();
            string password = PassBox.Text.Trim();

            // Validate input fields
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both email and password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database connection string
            string connectionString = "Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;";

            // SQL query to validate the user's credentials
            string query = "SELECT COUNT(*) FROM dbo.SignUp WHERE Email = @Email AND Password = @Password";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); // Open the database connection

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to avoid SQL Injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query and check if credentials are valid
                        int userCount = (int)cmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            // Successful login
                            DialogResult result = MessageBox.Show(
                                "Sign in successful!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            if (result == DialogResult.OK)
                            {
                                // Navigate to the Dashboard or main page
                                Dashboard dashboard = new Dashboard();

                                // Show the Dashboard
                                dashboard.Show();

                                // Set Dashboard to display the Home panel by default
                                dashboard.DisplayHomePanel();

                                // Hide the current SignIn form
                                this.Hide();
                            }
                        }
                        else
                        {
                            // Invalid credentials
                            MessageBox.Show("Invalid email or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the database operation
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void HomeB_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        private void PassCheck_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the password
            PassBox.UseSystemPasswordChar = !PassCheck.Checked;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text changes in the email box if needed
        }
    }
}
