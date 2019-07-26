using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayDemo
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            comboBox1.Items.Add(comboBox1.Text);
            comboBox1.Text = "";

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (string newName in comboBox1.Items)
            {
                txtOutput.Text = txtOutput.Text + newName + Environment.NewLine;
            }

        }
    }
}
