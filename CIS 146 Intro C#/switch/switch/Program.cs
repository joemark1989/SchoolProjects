using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string strState = "WA";
            double dblTax = 0;
            switch (strState)
            {
                case "WA":
                    dblTax = .089;
                    break;
                case "OR" || "MT":
                    dblTax = 0;
                case "CA":
                    dblTax = .098;
                case "NV":
                    dblTax = .057;
                case "ID":
                    dblTax = .078;
                case "default":
                    dblTax = .06;
                    break;



            }
            Console.WriteLine(dblTax);
            Console.ReadKey();
        }
    }
}
