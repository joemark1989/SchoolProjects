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
{   /* declaring the variables*/
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
        { /* does the math equation for the calculate*/
            try
            {
                /*lblOutput.Text = (double.Parse(txtCost.Text) * double.Parse(txtSQFt.Text)) + (double.Parse(txtLaborCosts.Text) * double.Parse(txtJobHours.Text)).ToString("c");*/
                dblCostSqFt = double.Parse(txtCost.Text);
                dblSQFt = double.Parse(txtSQFt.Text);
                dblLabor = double.Parse(txtLaborCosts.Text);
                dblJobHours = double.Parse(txtJobHours.Text);
                dblCost = (double.Parse(txtCost.Text) * double.Parse(txtSQFt.Text)) + (double.Parse(txtLaborCosts.Text) * double.Parse(txtJobHours.Text));
                lblOutput.Text = dblCost.ToString("C2");
            }
            catch
            {
                MessageBox.Show("Error. You must enter valid numbers. Please correct.");
                txtCost.Select();
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /* handles errors*/
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void About(object sender, EventArgs e)
        {
            /*MessageBox.Show("Stucco Pricing Developed by Joseph Markley 11/12/18 ");*/
            MessageBox.Show("Stucco Pricing" + Environment.NewLine + "Developed By Joseph" + Environment.NewLine + "11/12/18");
        }

        private void Clear(object sender, EventArgs e)
        {
            txtJobHours.Text = "";
            txtCost.Text = "";
            txtLaborCosts.Text = "";
            txtSQFt.Text = "";
            lblOutput.Text = "0";
            txtCost.Select();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
