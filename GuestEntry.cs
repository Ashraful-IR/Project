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
    public partial class GuestEntry : Form
    {
        public GuestEntry()
        {
            InitializeComponent();
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


            //MessageBox.Show("SUBMITED");

            GESubmit gESubmit = new GESubmit();
            gESubmit.Show();
        }
    }
}
