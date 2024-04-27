namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }
        public override double CalculateArea() => Height * Width;
        public override double CalculatePerimeter() => 2 * (Height + Width);
    }
}
