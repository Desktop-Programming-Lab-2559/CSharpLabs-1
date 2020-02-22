using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lab 4
//Task 2
//Variant 3
namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");

            double a = Convert.ToDouble(Console.ReadLine());

            bool intervalOne = a > 3 && a < 7;
            bool intervalTwo = a >= 8 && a < 9;
            bool intervalThree = a > 11 && a < 22.4;

            if (intervalOne || intervalTwo || intervalThree)
            {
                Console.WriteLine("Yes");
            } else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
