using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
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

        }

        private void SignUpL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp  signUp = new SignUp();
            signUp.Show();
        }

        private void SignInB_Click(object sender, EventArgs e)
        {
        
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

      

        private void PassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PassCheck.Checked )
            {
                PassBox.UseSystemPasswordChar = false;
            }
            else
            {
                PassBox.UseSystemPasswordChar = true;
            }
        }
    }
}
