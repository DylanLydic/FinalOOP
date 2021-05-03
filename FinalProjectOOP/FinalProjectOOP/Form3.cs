using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectOOP
{
    public partial class selectionForm : Form
    {
        public selectionForm()
        {
            InitializeComponent();
        }

        private void home3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hF3 = new Home();
            hF3.Show();
        }

        private void about3_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutForm aF3 = new aboutForm();
            aF3.Show();
        }

        private void ssb_Click(object sender, EventArgs e)
        {
            this.Hide();
            ssbForm ssbF = new ssbForm();
            ssbF.Show();
        }
    }
}
