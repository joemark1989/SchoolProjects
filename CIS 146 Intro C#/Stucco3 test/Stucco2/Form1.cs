using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stucco2
{
    public partial class Form1 : Form
    {
        double dblCostSqFt = 0;
        double dblSQFt = 0;
        double dblCost = 0;
        double dblLabor = 0;
        double dblJobHours =0;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dblCostSqFt = double.Parse(txtCost.Text);
            dblSQFt = double.Parse(txtSQFt.Text);
            dblLabor = double.Parse(txtLaborCosts.Text);
            dblJobHours = double.Parse(txtJobHours.Text);
            dblCost = dblCostSqFt * dblSQFt + dblLabor * dblJobHours;
            lblOutput.Text = dblCost.ToString("C2");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
