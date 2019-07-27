using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Add this import statement
using System.Data.SqlClient;

namespace CommandObject
{
    public partial class frmCommand : Form
    {
        public frmCommand()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //Connection string.
            String cnStr;
            SqlConnection cn = new SqlConnection();

            cnStr = "Data Source=134.39.173.35;Initial Catalog=DemoGuest;User ID=DemoGuest;Password=demo";

            //Assign Connection string to the connection object
            cn.ConnectionString = cnStr;
            //Open the connetion to the SQL Server
            cn.Open();


            //This statement creates the command object and passes in the SQL statement
            //then associates the command to the cn connection object
            SqlCommand cmd = new SqlCommand( "select * from tblZip",cn);

            //You would do something here.  It has not been passed to SQL Server as yet.
            cn.Close();

 
        }
    }
}