using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabsRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("epsilon = 10**");
            double epsilon = Math.Pow(10, Convert.ToInt32(Console.ReadLine()));

            double sum = Math.Log(2);
            double current = Math.Cos(2*x);
            int n = 1;

            while (Math.Abs(current) >= epsilon)
            {
                sum -= current;
                n++;
                current = (Math.Cos(2 * n * x)) / (2 * n);
            }

            double compareValue = Math.Log(Math.Abs(Math.Sin(x)));
                
            Console.WriteLine("result   = {0}", sum);
            Console.WriteLine("compare  = {0}", compareValue);
            Console.ReadKey();
        }
    }
}
