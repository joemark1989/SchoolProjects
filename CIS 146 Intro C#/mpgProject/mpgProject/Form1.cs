using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mpgProject
{
    public partial class Form1 : Form
    {
        double dblMiles = 0;
        double dblGallons = 0;
        double dblMpg = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblMpg_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            dblMiles = double.Parse(txtMiles.Text);
            dblGallons = double.Parse(txtGallons.Text);
            dblMpg = dblMiles / dblGallons;
            lblMpg.Text = "MPG: " + dblMpg;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtMpg_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
