using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAllDay
{ 
    class Program
    {
        static void Main(string[] args)
        {
            double dblBonus = 0;
            double dblSales = 20000;
            if (dblSales > 20000)
            {
                dblBonus = dblSales *.1;
            }
            else
            {
                dblBonus = dblSales * .02;
            }
            Console.WriteLine("Your bonus is "+dblBonus);
            Console.ReadKey();
        }
    }
    
}
