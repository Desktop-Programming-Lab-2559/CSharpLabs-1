using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(3, 3);

            m.Input();
            m.Output();

            Console.WriteLine(m.FindMinimum());
            Console.WriteLine(m.FindMaximum());

            Console.ReadKey();
        }
    }
}
