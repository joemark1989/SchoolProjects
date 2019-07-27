using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseball2015DataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.baseball2015DataSet.Players);

        }

        private void playersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            playersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playersBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playersBindingSource.AddNew();
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.playersTableAdapter.Update(this.baseball2015DataSet.Players);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            playersBindingSource.Filter = "namelast like '" + txtFind.Text + "%'";
        }
    }
}
