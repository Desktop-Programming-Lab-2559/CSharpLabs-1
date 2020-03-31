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
