using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int intSalary = 10000;
            double dblBonus = 1000;
            if (intSalary < 10000)
                dblBonus = 0;
            Console.WriteLine("Sorry no bonus");
            Console.ReadLine();


             
               
                
           
            
        
        }
    }
}
