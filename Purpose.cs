using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub_City_Management
{
    public partial class Purpose : Form
    {
        public Purpose()
        {
            InitializeComponent();
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
            Mission mission = new Mission();
            mission.Show();
        }

        private void Purpose_Load(object sender, EventArgs e)
        {

        }
    }
}
