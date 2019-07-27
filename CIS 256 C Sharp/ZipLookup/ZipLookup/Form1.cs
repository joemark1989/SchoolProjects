using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZipLookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zipCodes1.tblZipcodes' table. You can move, or remove it, as needed.
            this.tblZipcodesTableAdapter.Fill(this.zipCodes1.tblZipcodes);

        }


        private void tblZipcodesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblZipcodesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.zipCodes1);

        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            if (txtZip.Text.Length != 5 || txtZip.Text.Length == 0)
            {
                lblCity.Text = "Unknown";
                txtZip.Clear();
            }
            else
            {

            
            tblZipcodesBindingSource.Filter = "Zip like '" + txtZip.Text + "'";
                if (dataGridView1[0, 0].Value is null)
                {
                    lblCity.Text = "Unknown";
                    txtZip.Clear();
                }
                else
                {
                    lblCity.Text = dataGridView1[0, 0].Value.ToString();
                    lblState.Text = dataGridView1[1, 0].Value.ToString();
                }
            }
        }

        private void tblZipcodesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
