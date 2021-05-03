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

namespace FinalProjectOOP
{
    public partial class interForm : Form
    {
        public interForm()
        {
            InitializeComponent();
        }

        private void video1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=4SbXIl1swyE");
        }

        private void video2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=ci-2xNzVrX0");
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hF5 = new Home();
            hF5.Show();
        }

        private void select_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionForm sF5 = new selectionForm();
            sF5.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            gspForm gsF3 = new gspForm();
            gsF3.Show();
        }
    }
}
