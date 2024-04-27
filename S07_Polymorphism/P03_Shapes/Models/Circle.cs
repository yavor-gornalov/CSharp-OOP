namespace Shapes.Models
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
        public override double CalculatePerimeter() => 2 * Math.PI * Radius;
    }
}
