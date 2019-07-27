using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int intAge = 18;
            double dblRate = 0;
            //intCr = Credit Rating
            int intCr = 500;
            bool blnCreditCard = true;
            if (intAge >= 18 && intCr >= 500 && intAge < 24)
            {
                dblRate = .10;
            }
            if (intAge >= 24)
            {
                if (intCr >= 600 && intCr <= 700)
                {
                    dblRate = .095;
                }
                else if (intCr >= 700 && intCr <= 800)
                {
                    dblRate = .09;
                }
                else if (intCr >= 800)
                {
                    dblRate = .0875;
                }
                else
                {
                    dblRate = .10;
                }

            }
            if (blnCreditCard && dblRate > 0)
            {
                dblRate += .05;
            }
            Console.WriteLine(dblRate);
            Console.ReadKey();

            
        }
    }
}