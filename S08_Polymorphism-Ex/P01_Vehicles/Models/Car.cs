namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double AdditionalConsumtion { get; } = 0.9;

        public override void Refuel(double quantity) => FuelQuantity += quantity;
    }
}
