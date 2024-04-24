using Shapes.Interfaces;

namespace Shapes.Models
{
    public class Circle : IDrawable
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get => radius; private set => radius = value; }

        public void Draw()
        {
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
