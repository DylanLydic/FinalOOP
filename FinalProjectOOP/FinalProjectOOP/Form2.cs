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
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hF = new Home();
            hF.Show();
        }

        private void selection2_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionForm sF2 = new selectionForm();
            sF2.Show();
        }
    }
}
