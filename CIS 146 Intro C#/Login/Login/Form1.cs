using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        string strPassword = "d0g";
        string strLogin = "fred";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.ToLower() == strLogin && textPw.Text==strPassword)
            {

                MessageBox.Show("Welcome");
            }
            else
                MessageBox.Show("Invalid Login. Please try again.");
            textPw.Text = "";
            textPw.Focus();
          
            txtLogin.Text = "";
            txtLogin.Focus();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
