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
            double dblBonus;
            int intSalary = 10000;
            if (intSalary < 10000)
            {
                dblBonus = 0;

            }
            else
            {
                dblBonus = intSalary * .2;
            }
            Console.WriteLine("Your bonus is "+dblBonus);
            Console.ReadKey();
        }
    }
    
}
