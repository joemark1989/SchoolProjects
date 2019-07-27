using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cboName.Items.Add(cboName.Text);
            cboName.Text = "";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            foreach (string Name in cboName.Items)
            {
                txtName.Text = txtName.Text + Name+Environment.NewLine;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
