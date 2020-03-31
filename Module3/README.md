# Module 3
# Programming
# P1, 2020
# Variant 9

Circle.cs:

```csharp

using System;
namespace Module3
{
    public class Circle
    {
        protected double radius;

        protected const double COMPARISON_EPSILON = 0.00001;

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("radius must be non-negative number");

                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public Circle():this(0)
        {

        }

        public Circle(Circle c)
        {
            Radius = c.Radius;
        }

        public override string ToString()
        {
            return $"Circle({Radius})";
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetLength()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetSectorArea(double angleInRadians)
        {
            return Radius * Radius * angleInRadians / 2;
        }

        public static bool operator==(Circle c1, Circle c2)
        {
            return Math.Abs(c1.Radius - c2.Radius) < COMPARISON_EPSILON;
        }

        public static bool operator !=(Circle c1, Circle c2)
        {
            return !(c1 == c2);
        }

        public static Circle operator+(Circle c1, Circle c2)
        {
            return new Circle(c1.Radius + c2.Radius);
        }

        public static Circle operator -(Circle c1, Circle c2)
        {
            return new Circle(c1.Radius - c2.Radius);
        }

        public static Circle operator *(Circle c, double scalar)
        {
            return new Circle(c.Radius * scalar);
        }
    }
}

```

Sphere.cs:
```csharp
using System;
namespace Module3
{
    public class Sphere : Circle
    {
        public Sphere(double radius) : base(radius)
        {
        }

        public Sphere() : base(0)
        {

        }

        public new double GetArea()
        {
            return 4 * base.GetArea();
        }

        public double GetVolume()
        {
            return Math.PI * Math.Pow(Radius, 3);
        }

        public override string ToString()
        {
            return $"Sphere({Radius})";
        }

        public static bool operator ==(Sphere c1, Sphere c2)
        {
            return Math.Abs(c1.Radius - c2.Radius) < COMPARISON_EPSILON;
        }

        public static bool operator !=(Sphere c1, Sphere c2)
        {
            return !(c1 == c2);
        }

        public static Sphere operator +(Sphere c1, Sphere c2)
        {
            return new Sphere(c1.Radius + c2.Radius);
        }

        public static Sphere operator -(Sphere c1, Sphere c2)
        {
            return new Sphere(c1.Radius - c2.Radius);
        }

        public static Sphere operator *(Sphere c, double scalar)
        {
            return new Sphere(c.Radius * scalar);
        }
    }
}

```

Program.cs (test client):
```csharp
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
```
