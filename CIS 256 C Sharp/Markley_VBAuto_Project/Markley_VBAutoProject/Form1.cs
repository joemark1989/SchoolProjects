using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markley_VBAutoProject
{
    public partial class frmValleyBoulevard : Form
    {
        public frmValleyBoulevard()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLeather_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSubTotal_Click(object sender, EventArgs e)
        {

        }

        private void frmValleyBoulevard_Load(object sender, EventArgs e)
        {

        }

        private void lblTrade_Click(object sender, EventArgs e)
        {

        }

        private void txtTradeIn_TextChanged(object sender, EventArgs e)
        {
            lblTradePrice.Text = txtTradeIn.Text;
            double dblTradeIn = double.Parse(txtTradeIn.Text);
            lblTradePrice.Text = dblTradeIn.ToString("c");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            try {
                double basePrice = double.Parse(txtBasePrice.Text);

                if (basePrice < 0)
                {
                    MessageBox.Show("Price must be more than 0.");
                    txtBasePrice.Focus();
                    txtBasePrice.SelectAll();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Numbers only please.");
                txtBasePrice.Focus();
                txtBasePrice.SelectAll();

            }
            try
            {
                double tradeIn = double.Parse(txtTradeIn.Text);
                if (tradeIn < 0)
                {
                    MessageBox.Show("Price must be more than 0.");
                    txtTradeIn.Focus();
                    txtTradeIn.SelectAll();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Numbers only please.");
                txtTradeIn.Focus();
                txtTradeIn.SelectAll();

              
            }

            double stereoPrice = 0, leatherPrice = 0, navPrice = 0;

            if (chkBoxStereo.Checked)
            {
                stereoPrice = 201.21;
            }
            if (chkBoxLeather.Checked)
            {
                leatherPrice = 999.99;
            }
            if (chkBoxNav.Checked)
            {
                navPrice = 1199.99;
            }

            double exteriorFinish = 0;

            if (radPearlized.Checked)
            {
                exteriorFinish = 320.00;
            }
            else if (radCustom.Checked)
            {
                exteriorFinish = 499.99;
            }

            double dblBasePrice = double.Parse(txtBasePrice.Text);
            double dblTradeIn = double.Parse(txtTradeIn.Text);

            double extras = stereoPrice + leatherPrice + navPrice;

            double subTotal = extras + exteriorFinish + dblBasePrice;

            lblSubTotalPrice.Text = subTotal.ToString("c");

            

            double taxrate = 0.08, tax = 0;
            tax = subTotal * taxrate;
            lblTaxPrice.Text = tax.ToString("c");

            double total = 0;
            total = subTotal + tax;
            lblTotalPrice.Text = total.ToString("c");

            double totalAmount = 0;
            totalAmount = total - dblTradeIn;
            lblAmountPrice.Text = totalAmount.ToString("c");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            double tradeInReset = 0.00;
            txtBasePrice.Text = "";
            txtTradeIn.Text = tradeInReset.ToString("f");
            txtBasePrice.Focus();

            chkBoxStereo.Checked = false;
            chkBoxLeather.Checked = false;
            chkBoxNav.Checked = false;

            radStandard.Checked = true;
            radPearlized.Checked = false;
            radCustom.Checked = false;

            lblSubTotalPrice.Text = "";
            lblTaxPrice.Text = "";
            lblTotalPrice.Text = "";
            lblTradePrice.Text = "";
            lblAmountPrice.Text = "";
        }
    }
}
