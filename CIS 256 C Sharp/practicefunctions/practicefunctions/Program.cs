using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicefunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat cCat = new Cat();
            cCat.Hiss();

            Cat.Meow();

            cCat.SetAge(18); 

            Console.WriteLine(cCat.GetAge());


            cCat.Funky(8, "jump");

            Console.ReadKey();


        }
            
    }
}
