using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabsRunner
{
    class Program
    {
        static double f(double x)
        {
            return Math.Sqrt(4*x + Math.Sin(Math.Pow(x, 1/3)));
        }

        static double integral(double a, double b, int n)
        {
            double sum = 0;
            double h = (b - a) / n;

            double ptr = a+h;

            while (ptr <= b)
            {
                sum += f(ptr) * h;
                ptr += h;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double u = integral(a, 3, n) + integral(a,b,n);

            Console.WriteLine(u);
            Console.ReadKey();
        }
    }
}
