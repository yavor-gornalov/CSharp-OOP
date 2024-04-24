using Cars.Interfaces;
using System.Text;

namespace Cars.Models
{
    public class Car : ICar
    {
        private string _model;
        private string _color;

        public string Model => _model;
        public string Color => _color;

        public Car(string model, string color)
        {
            _model = model;
            _color = color;
        }

        public string Start() => "Engine start";
        public string Stop() => "Breaaak!";

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Color} {this.GetType().Name} {Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().Trim();
        }
    }
}
