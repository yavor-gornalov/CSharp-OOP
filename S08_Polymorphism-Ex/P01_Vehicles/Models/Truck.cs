namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double AdditionalConsumtion { get; } = 1.6;

        public double RefuelLimitation { get; } = 0.95;

        public override void Refuel(double quantity) => FuelQuantity += RefuelLimitation * quantity;
    }
}
