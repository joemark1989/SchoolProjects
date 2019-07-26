using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string strState = "WA";
            double dblTax = 0;
            if (strState == "WA")
            {
                dblTax = .089;
            }
            else if (strState == "OR" || strState == "MT")
            {
                dblTax = 0;
            }
            else if (strState == "CA")
            {
                dblTax = .098;
            }
            else if (strState == "NV")
            {
                dblTax = .057;
            }
            else if (strState == "ID")
            {
                dblTax = .078;
            }
            else
            {
                dblTax = .06;
            }
            Console.WriteLine(dblTax);
            Console.ReadKey();
        }
    }
}
