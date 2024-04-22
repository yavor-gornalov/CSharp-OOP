namespace NeedForSpeed.Models
{
    public class Vehicle
    {
        public double DefaultFuelConsumption { get; set; } = 1.25;
        public virtual double FuelConsumption
        {
            get => FuelConsumption;
            set => FuelConsumption = DefaultFuelConsumption;
        }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public virtual void Drive(double kilometers) => Fuel -= FuelConsumption * kilometers;



    }
}
