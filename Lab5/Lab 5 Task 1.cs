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
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double P = 1;

            for (int i = 0; i < n; i++)
            {
                P *= Math.Pow(a + i, 2); 
            }

            Console.WriteLine(P);
            Console.ReadKey();
        }
    }
}
