# Lab 11
# Variant 3
# P1, 2020

| **Клас** | **Квадрат** |
| ------ | ------ |
| **Поля** | для зберігання довжин сторін; |
| **Методи** | конструктор без параметрів, конструктор з параметрами, конструктор копіювання; |
|    | введення/виведення даних; |
|    | визначення площі; |
|    | визначення периметру; |
|    | порівняння з іншим квадратом; |
|    | перевантаження операторів + (додавання довжин сторін), – (віднімання довжин відповідних сторін), * (множення сторін на деяке число).|


## Square.cs
```csharp
using System;
namespace Task1
{
    public class Square
    {
        private double side;

        private const double COMPARSION_EPSILON = 0.00001;

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
                    throw new Exception("square side must be non-negative");
                }

                side = value;
            }
        }

        public Square(double side)
        {
            Side = side;
        }

        public Square() : this(0)
        {

        }

        public Square(Square other)
        {
            Side = other.Side;
        }

        public void Input()
        {
            Console.Write("Square Side =");
            Side = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Square({Side})";
        }

        public double Area()
        {
            return Side * Side;
        }

        public double Perimeter()
        {
            return Side * 4;
        }

        public static bool operator ==(Square s1, Square s2)
        {
            return Math.Abs(s1.Side - s2.Side) <= COMPARSION_EPSILON;
        }

        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }

        public static Square operator +(Square s1, Square s2)
        {
            return new Square(s1.Side + s2.Side);
        }

        public static Square operator -(Square s1, Square s2)
        {
            return new Square(s1.Side - s2.Side);
        }

        public static Square operator *(Square sq, double scalar)
        {
            return new Square(sq.Side * scalar);
        }
    }
}

```


## Test:

```csharp
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

```