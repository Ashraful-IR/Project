using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sub_City_Management
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            Form1 form1 =(Form1)sender;
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ASHRAF\\SQLEXPRESS02;Initial Catalog=\"SubCity Management\";Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into SignUp  values (@FullName, @PhoneNumber, @Email, @HouseAddress, @Password, @ConfirmPassword)", con);
            cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Email", textBox2.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@HouseAddress", textBox5.Text);
            cmd.Parameters.AddWithValue("@Password", textBox7.Text);
            cmd.Parameters.AddWithValue("@ConfirmPassword", textBox6.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Welcome to Bashundhara");
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
