using Cars.Interfaces;
using System.Text;

namespace Cars.Models
{
    public class Tesla : Car, IElectricCar
    {

        private int _battery;

        public Tesla(string model, string color, int battery) : base(model, color)
        {
            _battery = battery;
        }

        public int Battery => _battery;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Color} {this.GetType().Name} {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().Trim();
        }
    }
}
