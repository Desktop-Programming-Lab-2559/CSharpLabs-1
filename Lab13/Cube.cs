using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
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
}
