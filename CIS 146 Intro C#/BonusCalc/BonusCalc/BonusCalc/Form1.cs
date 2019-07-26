using System;
using System.Windows.Forms;

namespace BonusCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblIncome;
            double dblBonus;
            double dblBonusPercent;
            dblBonusPercent = double.Parse(txtBonusPct.Text);
            dblIncome = double.Parse(txtSalary.Text);
            dblBonus = dblIncome * dblBonusPercent;
            lblBonus.Text = dblBonus.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing");
            
        }
    }
}
