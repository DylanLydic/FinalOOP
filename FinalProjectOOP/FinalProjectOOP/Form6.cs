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
    public partial class beginForm : Form
    {
        public beginForm()
        {
            InitializeComponent();
        }

        private void video_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=jL_pOwxMKKQ");
        }

        private void video2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=x-v0We5kHI4");
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hF = new Home();
            hF.Show();
        }

        private void select_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionForm sF = new selectionForm();
            sF.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            gspForm gsF = new gspForm();
            gsF.Show();
        }
    }
}
