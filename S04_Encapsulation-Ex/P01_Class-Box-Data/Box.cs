
using System.Text;

namespace Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                    ThrowValidatioExeption(nameof(this.Length));
                length = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                    ThrowValidatioExeption(nameof(this.Width));
                width = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                    ThrowValidatioExeption(nameof(this.Height));
                height = value;
            }
        }

        public double SurfaceArea() => 2 * (Length * Width + Length * Height + Height * Width);

        public double LateralSurfaceArea() => 2 * (Length * Height + Width * height);

        public double Volume() => Length * Width * Height;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():F2}");
            sb.AppendLine($"Volume - {Volume():F2}");

            return sb.ToString().Trim();
        }

        private static void ThrowValidatioExeption(string propertyName)
        {
            throw new ArgumentException($"{propertyName} cannot be zero or negative.");
        }
    }
}
