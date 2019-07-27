using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringNames
{
    public partial class Form1 : Form
    {
        string firstName;
        string middleName;
        string lastName;
        string name;
        string fullName;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }
        //Closes the application//
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetName_Click(object sender, EventArgs e)
        {

            fullName = txtFullName.Text;
            List<string> Length = new List<string>();
            Length = fullName.Split(' ').ToList();
            int Location = fullName.IndexOf(" ") + 1;

            if (Length.Count == 1)
            { 
               lblLastName.Text = fullName.Substring(0);
               lblFirstName.Text = "";
               lblMiddleName.Text = "";
            

            }


            else if (Length.Count == 2)
            {
                lblFirstName.Text = fullName.Substring(0, Location);
                lblLastName.Text = fullName.Substring(Location);
                lblMiddleName.Text = "";

            }
            else if (Length.Count == 3)
            {
                lblFirstName.Text = fullName.Substring(0, Location);
                lblMiddleName.Text = fullName.Substring(lblFirstName.Text.Length, Location);
                lblLastName.Text = fullName.Substring(lblFirstName.Text.Length + lblMiddleName.Text.Length);

            }
            else if (Length.Count==0)
            {
                lblFirstName.Text = "";
                lblMiddleName.Text = "";
                lblLastName.Text = "";
            }

            else
            {
            MessageBox.Show("Invalid Entry");
            }

        }
    }
}
