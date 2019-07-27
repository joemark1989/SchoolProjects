using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_Low_Game
{
  

    public partial class frmHighLow : Form
    {
        int intRandomNumber;
        int intGuess = 0;
        int intGuesses = 0;
        int intBestScore = 99;

        public frmHighLow()
        {
            InitializeComponent();
            lblBestScore.Text = String.Format("Best (Low) Score: 99");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnRandomNumber = new Random();
            intRandomNumber = rnRandomNumber.Next(0, 1000);
            lblNumGuesses.Text = String.Format("Number of Guesses: {0}", intGuesses);
            btnStart.Enabled = false;
            btnGuess.Enabled = true;
            txtGuess.Enabled = true;
            txtGuess.Focus();
            lblRandomNumber.Text = intRandomNumber.ToString();
            lblBestScore.Text = String.Format("Best (Low) Score: ?");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            intGuesses++;
            lblNumGuesses.Text = String.Format("Number of Guesses: {0}", intGuesses);
            if (!isNumberInt(txtGuess.Text))
            {
                MessageBox.Show("Integers Only.  Retry.");
                txtGuess.Focus();
                txtGuess.Clear();
            }
            else
            {
                intGuess = Int32.Parse(txtGuess.Text);
                if (intGuess > intRandomNumber)
                {
                    MessageBox.Show("Too High");
                    txtGuess.Clear();
                    txtGuess.Focus();
                }
                else if (intGuess < intRandomNumber)
                {
                    MessageBox.Show("Too Low");
                    txtGuess.Clear();
                    txtGuess.Focus();
                }
                else
                {
                    MessageBox.Show("You guessed it in " + intGuesses + " attempts.");
                    btnGuess.Enabled = false;
                    txtGuess.Enabled = false;
                    btnStart.Enabled = true;

                    if (intGuesses < intBestScore)
                    {
                        intBestScore = intGuesses;
                        lblBestScore.Text = string.Format("Best (Low) Score: {0}", intBestScore);
                        lblNumGuesses.Text = string.Format("Number of Guesses: 0");
                        intGuesses = 0;
                        txtGuess.Clear();

                    }
                }
            }
        }
        private bool isNumberInt(string strInput)
        {
            try
            {
                int intValue = int.Parse(strInput);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }   
}
