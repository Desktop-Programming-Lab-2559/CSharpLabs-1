using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabsRunner
{
    class Program
    {

        static long recur(long i)
        {
            if (i == 0) return 1;

            return recur(i-1) + 2 * i;
        }
       

        static void Main(string[] args)
        {
            Console.WriteLine(recur(10));
            Console.ReadKey();
        }
    }
}
