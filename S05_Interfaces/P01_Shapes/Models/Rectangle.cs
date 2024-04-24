using Shapes.Interfaces;

namespace Shapes.Models
{
    public class Rectangle : IDrawable
    {
        private int height;
        private int width;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public int Height
        {
            get => height;
            private set => height = value;
        }
        public int Width
        {
            get => width;
            private set => width = value;
        }

        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height - 1; ++i)
                DrawLine(Width, '*', ' ');
            DrawLine(Width, '*', '*');
        }
        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
                Console.Write(mid);
            Console.WriteLine(end);
        }
    }
}
