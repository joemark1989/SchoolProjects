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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //Connection String
            String cnStr, strSQL;
            SqlConnection cn = new SqlConnection();

            cnStr = "Data Source=134.39.173.35;Initial Catalog=DEMOGUEST;User ID=DEMOGUEST;password=sp0kan3";

            //Assign Connection String to the connection object
            cn.ConnectionString = cnStr;

            //Open the Connection to SQL Server
            cn.Open();

            //This concatenates the insert statement.  Of course you would add loads of error checking.
            strSQL = "insert into tblZipCodes (zip,city,state) values ('" + txtZip.Text + "','" + txtCity.Text + "','" + txtState.Text + "')";

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
    }
}