using System;

namespace Module3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Test Circle
            Circle c = new Circle(3);
            Console.WriteLine(c);
            Console.WriteLine(c.GetArea());
            Console.WriteLine(c.GetLength());
            Console.WriteLine(c.GetSectorArea(3.1415));
            Console.WriteLine(c*3);
            Console.WriteLine(c+c);
            Console.WriteLine(c-c);

            try
            {
                Circle ic = new Circle(-3);
                Console.WriteLine(ic);
            } catch(Exception e)
            {
                Console.WriteLine($"Negative radius throws exception ({e.Message}).");
            }

            //Sphere Test
            Sphere s = new Sphere(2);
            Console.WriteLine(s);
            Console.WriteLine(s*3);
            Console.WriteLine(s+s);
            Console.WriteLine(s-s);
            Console.WriteLine(s.GetVolume());
            Console.WriteLine(s.GetArea());

            Console.ReadKey();
        }
    }
}
