using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string callOut = "For those about to ROCK!";
            string response = " We salute you!";

            Console.WriteLine(callOut + response);
            Console.ReadKey();

            Console.WriteLine(string.Concat(callOut, response));
            Console.ReadKey();

            Console.WriteLine(callOut.Contains("ROCK"));
            Console.ReadKey();

            Console.WriteLine(callOut.Contains("rock"));
            Console.ReadKey();

            Console.WriteLine(callOut.Contains("rock".ToUpper()));
            Console.ReadKey();

            Console.WriteLine(callOut+ response.ToLower());
            Console.ReadKey();


            Console.WriteLine(callOut.IndexOf('o'));
            Console.ReadKey();

            Console.WriteLine(callOut.LastIndexOf('o'));
            Console.ReadKey();

            Console.WriteLine(callOut.Remove(4, 5));
            Console.ReadKey();

            Console.WriteLine(callOut.Replace('o', '$'));
            Console.ReadKey();

            // equal method
            Console.WriteLine(callOut.Equals(response));
            Console.ReadKey();

            //sub string method
            Console.WriteLine(callOut.Substring(2,1));
            Console.ReadKey();

        }
    }
}
