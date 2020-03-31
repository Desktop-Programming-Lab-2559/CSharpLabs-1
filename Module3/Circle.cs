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
