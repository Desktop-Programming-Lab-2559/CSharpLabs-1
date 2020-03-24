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
            bool condition = x > 0;
            double result = condition ? 0 : 1;

            for (int i = 1; i <= 5; i++)
            {
                if (condition)
                {
                    result += Math.Pow(x, i);
                } else
                {
                    result *= Math.Pow(x, i);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            double u = f(a) + f(2) + f(b);

            Console.WriteLine(u);
            Console.ReadKey();
        }
    }
}
