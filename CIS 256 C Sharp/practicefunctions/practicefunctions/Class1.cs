using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicefunctions
{
    class Cat
    {
        public string name = string.Empty;
        public int age = 0;
        public void Hiss()
        {
            Console.WriteLine("Hiss");
        }
        public static void Meow()
        {
            Console.WriteLine("Meow");
        }
        public int GetAge()
        {
            return age;
        }
        
        public void SetAge(int nAge)
        {
            age = nAge;
        }

        /// <summary>
        /// Getting Funky
        /// </summary>
        /// <param name="Time">The number of times to perform an action</param>
        /// <param name="Action">The action to perform</param>

        public void Funky(int Time, string Action)
        {
            for (int i = 0; i < Time; i++)
            {
                Console.WriteLine(Action + " " + i + "times");
            }
            int myInt = 7 % 3;
            Console.WriteLine(myInt);
            Console.ReadKey();
        }

    }
}
