using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_and_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int intYears = 3;
            double dblSales = 50000;
            Boolean blnBonus;
            if (intYears > 3)
            {
                blnBonus = true;
                Console.WriteLine("Yes");
            }
            else
            {
                blnBonus = false;
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }   
    }
}
