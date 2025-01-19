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
    public partial class GESubmit : Form
    {
        private Dashboard _dashboard; // Reference to Dashboard
        public GESubmit(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard; // Store the Dashboard reference
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GESubmit_Load(object sender, EventArgs e)
        {

        }
    }
}
