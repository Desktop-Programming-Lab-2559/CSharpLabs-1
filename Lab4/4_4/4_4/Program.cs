using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lab 4
//Task 4
//Variant 3
namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double compareValue = x * x + Math.Log(x);
            double y = 0;

            if (compareValue > 0)
            {
                y = Math.Cos(compareValue);
            } else if (compareValue < 0)
            {
                y = 1 / compareValue;
            } else
            {
                y = Math.Cos(x);
            }


            Console.WriteLine("y = {0}", y);
            Console.ReadKey();
        }
    }
}
