# Lab 13
# Programming
# P1, 2020
# Variant 3

Square.cs:

```csharp

class Square
    {
        private double side;

        public double Side
        {
            get
            {
                return side;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Square side cannot be negative.");
                }
            }
        }

        public Square(double side)
        {
            this.side = side;
        }

        public Square() : this(0)
        {

        }

        public override string ToString() {
            return $"Square({side})";
        }

        public double GetArea()
        {
            return side * side;
        }

        public double GetPerimeter()
        {
            return side * 4;
        }

        public static Square operator+(Square a, Square b)
        {
            return new Square(a.Side + b.Side);
        }

        public static Square operator -(Square a, Square b)
        {
            return new Square(a.Side - b.Side);
        }

        public static Square operator *(Square a, double scalar)
        {
            return new Square(a.Side * scalar);
        }
    }

```

Cube.cs:
```csharp
 class Cube : Square
    {
        public Cube(double side) : base(side)
        {

        }

        public Cube() : base()
        {

        }

        public override string ToString()
        {
            return $"Cube({Side})";
        }

        public new double GetArea()
        {
            return Side * Side * Side;
        }

        public new double GetPerimeter()
        {
            return Side * 12;
        }

        public double GetVolume()
        {
            return Side * Side * Side;
        }

        public static Cube operator +(Cube a, Cube b)
        {
            return new Cube(a.Side + b.Side);
        }

        public static Cube operator -(Cube a, Cube b)
        {
            return new Cube(a.Side - b.Side);
        }

        public static Cube operator *(Cube a, double scalar)
        {
            return new Cube(a.Side * scalar);
        }
    }
```

Program.cs (test client):
```csharp
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
```
