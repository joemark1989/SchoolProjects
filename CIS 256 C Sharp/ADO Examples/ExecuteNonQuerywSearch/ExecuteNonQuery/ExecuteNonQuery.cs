using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExecuteNonQuery
{
    public partial class frmCommand : Form
    {
        public frmCommand()
        {
            InitializeComponent();
        }

        //Connection String
        String cnStr = "Data Source=134.39.173.35;Initial Catalog=DEMOGUEST;User ID=DEMOGUEST;password=demo";
        String strSQL;

        SqlConnection cn = new SqlConnection();


        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Assign Connection string to connection object
            cn.ConnectionString = cnStr;


            //Open the Connection to SQL Server
            cn.Open();

            //This concatenates the insert statement.  Of course you would add loads of error checking.
            strSQL = "insert into tblZipCodes values ('" + txtZip.Text + "','" + txtCity.Text + "','" + txtState.Text + "')";

            //this statement creates the command object and passes in the SQL statement
            //then associates the command to the cn connection object
            SqlCommand cmd = new SqlCommand(strSQL, cn);

            //Execute command.  Returns no rows.
            cmd.ExecuteNonQuery();

            //Close Connection
            cn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnInsert.Enabled = false;
            lblFind.Visible = true;
            txtZip2Find.Visible = true;
            txtZip2Find.Focus();

        }

        private void txtZip2Find_Leave(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();

            //Assign connection string to the connection object
            cn.ConnectionString = cnStr;
            //Open the connection to SQL Server
            cn.Open();

            //This statement creates a command object and passes in a SQL Statement
            //The associates the command to the cn Connection Object
            SqlCommand cmd = new SqlCommand("Select city,state,zip from tblZipcodes where zip='" + txtZip2Find.Text + "'",cn);

            //Open a DataReader
            SqlDataReader rdrZip = cmd.ExecuteReader();

            //Attempt to read record into datareader
            rdrZip.Read();
            //If found, data reader has rows else not found
            if (rdrZip.HasRows)
            { //Move text from rdr into textboxes
                txtCity.Text = rdrZip["city"].ToString();
                txtState.Text = rdrZip["state"].ToString();
                txtZip.Text = rdrZip["zip"].ToString();
            }
            else
            {
                MessageBox.Show("Zip Not Found");
            }
            cn.Close();

            //Restore buttons
            btnSearch.Enabled = true;
            btnInsert.Enabled = true;
            lblFind.Visible = false;
            txtZip2Find.Visible = false;
          
        }
    }
}