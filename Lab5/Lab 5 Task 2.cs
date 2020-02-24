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
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (n != 0)
            {
                int digit = n % 10;
                n = n / 10;

                if (digit == 1) count++;
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
