using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Add this import statement
using System.Data.SqlClient;

namespace ConnectionObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void frmADODemo_Click(object sender, EventArgs e)
        {
            //NOTE necessary using statement for ADO SQL and ODBC above
            //Connection string.
            //Declare string to hold connection information and connection object
            String cnStr;
            SqlConnection cn = new SqlConnection();

            //Note: The connection string defaults to SQL Server
            cnStr = "Data Source=134.39.173.35;Initial Catalog=DEMOGUEST;User ID=DEMOGUEST;Password=demo";

            //Assign Connection string to the connection object
            cn.ConnectionString = cnStr;
            //Open the connetion to the SQL Server
            cn.Open();
            //You would do something here

            //Close the connection to SQl Server
            cn.Close();

        }
    }
}