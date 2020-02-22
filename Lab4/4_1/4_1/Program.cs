using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lab 4
// Task 1
// Variant 3
namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double side = Convert.ToDouble(Console.ReadLine());

            Console.Write("h = ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * side * height;

            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
