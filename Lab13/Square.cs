using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
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
}
