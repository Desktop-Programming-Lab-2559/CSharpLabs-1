using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lab 4
//Task 3
//Variant 3
namespace _4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1, x2, x3, y1, y2, y3: ");

            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double a = 0;
            double b = 0;
            double c = 0;

            if (AB >= BC && AB >= AC)
            {
                c = AB;
                a = BC;
                b = AC;
            } else if (BC >= AB && BC >= AC)
            {
                c = BC;
                a = AB;
                b = AC;
            } else
            {
                c = AC;
                a = AB;
                b = BC;
            }

            if (c*c > a*a + b*b)
            {
                Console.WriteLine("Triangle is acute.");
            } else
            {
                Console.WriteLine("Triangle is NOT acute.");
            }

            Console.ReadKey();
        }
    }
}
