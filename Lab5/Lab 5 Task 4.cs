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
            int x0 = 1;
            int x1 = 1;
            int xi = 0;

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                xi = x0 + x1;
                x0 = x1;
                x1 = xi;
            }

            Console.WriteLine(xi);
            Console.ReadKey();
        }
    }
}
