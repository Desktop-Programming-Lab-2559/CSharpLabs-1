using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Square s = new Square(3);
            Square s2 = new Square(2);

            Console.WriteLine(s);
            Console.WriteLine(s+s2);
            Console.WriteLine(s-s2);
            Console.WriteLine(s*3);
            Console.WriteLine(s.Area());
            Console.WriteLine(s.Perimeter());
        }
    }
}
