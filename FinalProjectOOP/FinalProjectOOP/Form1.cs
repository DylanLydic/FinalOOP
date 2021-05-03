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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            this.Hide();
            aboutForm aF = new aboutForm();
            aF.Show();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void about_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void selection_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionForm sF = new selectionForm();
            sF.Show();
        }
    }
} 
