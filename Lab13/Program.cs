using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(4);
            Console.WriteLine(square);
            Console.WriteLine(square * 2);
            Console.WriteLine(square.GetPerimeter());
            Console.WriteLine(square.GetArea());

            Cube c = new Cube(3);
            Console.WriteLine(c);
            Console.WriteLine(c * 1.5);

            Console.WriteLine(c.GetPerimeter());
            Console.WriteLine(c.GetArea());
            Console.WriteLine(c.GetVolume());
            Console.ReadKey();
        }
    }
}
