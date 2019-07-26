using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int intSalary = 10000;
            double dblBonus = 0;
            if (intSalary < 10000)
            {
                dblBonus = 0;

            }
            else
            {
                dblBonus = 1000;
            }
            Console.WriteLine("Your bonus is " + dblBonus);
            Console.ReadLine();





        }
    }
}
