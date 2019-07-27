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

            cnStr = "Data Source=134.39.173.35;Initial Catalog=contributions;User ID=DEMOGUEST;Password=sp0kan3";

            //Assign Connection string to the connection object
            cn.ConnectionString = cnStr;
            //Open the connection to the SQL Server
            cn.Open();


            //This statement creates the command object and passes in the SQL statement
            //then associates the command to the cn connection object
            SqlCommand cmd = new SqlCommand( "select distinct state from tblZipcodes order by state",cn);

            //Open a DataReader
            SqlDataReader rdrZip = cmd.ExecuteReader();

           //Read record-by-record into the list box from the data reader
            //comboBox1.DataSource = rdrZip;

            while (rdrZip.Read())
            {
                String myString = rdrZip["state"].ToString().Trim(); 
                comboBox1.Items.Add(myString);
           
            }

            cn.Close();

 
        }
    }
}