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
    public partial class ssbForm : Form
    {
        public ssbForm()
        {
            InitializeComponent();
        }

        private void gsp_Click(object sender, EventArgs e)
        {
            this.Hide();
            gspForm gspF = new gspForm();
            gspF.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string i = Console.ReadLine();


            if (i == "Beginner")
            {
                this.Hide();
                beginForm bgF = new beginForm();
                bgF.Show();
            }
            else if (i == "Intermediate")
            {
                this.Hide();
                interForm iF = new interForm();
                iF.Show();
            }
            else if (i == "Advanced")
            {
                this.Hide();
                advForm advF = new advForm();
                advF.Show();
            }
           
        }
        //I could not seem to figure out how to get this text box to accept these inputs and the first iteration was supposed to accept number but it kept throwing errors
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectionForm sF2 = new selectionForm();
            sF2.Show();
        }

        private void textbox_Enter(object sender, EventArgs e)
        {
            string i = Console.ReadLine();

            if (i == "Beginner")
            {
                this.Hide();
                beginForm bgF = new beginForm();
                bgF.Show();
            }
            else if (i == "Intermediate")
            {
                this.Hide();
                interForm iF = new interForm();
                iF.Show();
            }
            else if (i == "Advanced")
            {
                this.Hide();
                advForm advF = new advForm();
                advF.Show();
            }
        }

        private void bg_Click(object sender, EventArgs e)
        {
            this.Hide();
            beginForm bgF = new beginForm();
            bgF.Show();
        }

        private void inter_Click(object sender, EventArgs e)
        {
            this.Hide();
            interForm inF = new interForm();
            inF.Show();
        }

        private void adv_Click(object sender, EventArgs e)
        {
            this.Hide();
            advForm adF2 = new advForm();
            adF2.Show();
        }
    }
}
