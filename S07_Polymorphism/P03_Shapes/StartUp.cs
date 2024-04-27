using Shapes.Models;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(4, 5);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());

            var circle = new Circle(1);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());
        }
    }
}