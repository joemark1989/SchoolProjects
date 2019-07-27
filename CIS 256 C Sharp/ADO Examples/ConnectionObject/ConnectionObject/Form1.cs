using System;
using System.Data.SqlClient;
using System.Windows.Forms;

//Add this import statement

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
            //String cnStr;

            SqlConnection cn = new  SqlConnection("Data Source=135.39.173.35;Initial Catalog=Contributions;User ID=SQLUser;Password=sp0kan3");
 
            //Note: The connection string defaults to SQL Server
            //cnStr = ;

            //Assign Connection string to the connection object
            //cn.ConnectionString = cnStr;
            //Open the connetion to the SQL Server
            cn.Open();
            //You would do something here

            //Close the connection to SQl Server
            cn.Close();

        }
    }
}