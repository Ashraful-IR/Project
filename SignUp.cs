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
            
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
           Application.Exit();
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
            cmd.Parameters.AddWithValue("@FullName", FNBox.Text);
            cmd.Parameters.AddWithValue("@Email", EBox.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", int.Parse(PNBox.Text));
            cmd.Parameters.AddWithValue("@HouseAddress", HABox.Text);
            cmd.Parameters.AddWithValue("@Password", PBox.Text);
            cmd.Parameters.AddWithValue("@ConfirmPassword", CPBox.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Welcome to Bashundhara");
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
