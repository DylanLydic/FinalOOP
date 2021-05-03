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
    public partial class gspForm : Form
    {
        public gspForm()
        {
            InitializeComponent();
        }

        private void gspbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            ssbForm ssF = new ssbForm();
            ssF.Show();
        }
    }
}
