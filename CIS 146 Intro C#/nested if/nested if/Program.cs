using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nested_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblTax = 0;
            string strState = "WA";
            string strCity = "Seattle";
            if (strState == "WA")
            {
                if (strCity == "Seattle")
                {
                    dblTax = .09;
                }
                else if (strCity == "Spokane")
                {
                    dblTax = .087;

                }
                else
                {
                    dblTax = .084;
                }
            }
            if (strState == "CA")
            {
                dblTax = .098;
            }
            Console.WriteLine(dblTax);
            Console.ReadKey();
        }  
    }
}
