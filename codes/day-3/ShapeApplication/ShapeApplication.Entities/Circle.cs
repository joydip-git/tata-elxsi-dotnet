using static System.Math;

namespace ShapeApplication.Entities
{
    public class Circle : IShape
    {
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public double CalculateArea()
        {
            return this.Radius * this.Radius * PI;
        }
    }

    abstract class A : IShape
    {
        public abstract double CalculateArea();
    }
}
