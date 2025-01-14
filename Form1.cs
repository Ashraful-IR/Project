using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sub_City_Management
{
    public partial class Form1 : Form
    {
        public object Password { get; private set; }
        public string Email { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string Sb = Sbutton.Text;
        }

        private void Sbutton_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=ASHRAF\\SQLEXPRESS;Initial Catalog=\"Sign Up\";Integrated Security=true;Trust Server Certificate=true";

            //string query = "SELECT COUNT(*) FROM section WHERE Id = @Id AND Name = @Name";
            string query = "SELECT COUNT(*) FROM section WHERE Email = @email AND Password= @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    SqlParameter sqlParameter = command.Parameters.AddWithValue("@Password", password);

                    connection.Open();

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Signin successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Form2 f2 = new Form2(int.Parse(Email));
                        f2.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password.", "Signin Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
