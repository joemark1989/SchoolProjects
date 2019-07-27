using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stucco
{
    public partial class Form1 : Form
    {
        double dblCostSqFt = 0;
        double dblSQFt = 0;
        double dblCost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            dblCostSqFt = double.Parse(txtCost.Text);
            dblSQFt = double.Parse(txtSQFt.Text);
            dblCost = dblCostSqFt * dblSQFt;
            lblTotalCost.Text = dblCost.ToString("C2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {

        }
    }
}
