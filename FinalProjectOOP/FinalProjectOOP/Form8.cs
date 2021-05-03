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
    public partial class advForm : Form
    {
        public advForm()
        {
            InitializeComponent();
        }

        private void tourn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://smash.gg/tournaments?per_page=30&filter=%7B%22upcoming%22%3Atrue%2C%22videogameIds%22%3A%220%22%7D&page=1");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            gspForm gsF = new gspForm();
            gsF.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hme = new Home();
            hme.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"Chromium\"/>" +
            "</head><body>" +
            "<iframe width=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = "https://www.youtube.com/watch?v=dGNXkroW9YY";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}
