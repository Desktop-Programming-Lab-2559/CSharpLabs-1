using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());

            Number[] numbers = new Number[n + m];

            long sol1 = 0;
            long sol2 = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Int({i}) = ");
                numbers[i] = new IntNumber(Convert.ToInt32(Console.ReadLine()));

                sol1 += numbers[i].GetFirstDigit();
            }

            for (int i = 0; i < m; i++)
            {
                Console.Write($"Real({i}) = ");
                numbers[n+i] = new RealNumber(Convert.ToDouble(Console.ReadLine()));

                sol2 += numbers[n+i].GetLastDigit();
            }

            for (int i = 0; i < n+m; i++)
            {
                Console.WriteLine($"{numbers[i].GetDigitsSum()} | {numbers[i].GetFirstDigit()} | {numbers[i].GetLastDigit()}");
            }

            Console.ReadKey();
        }
    }
}
