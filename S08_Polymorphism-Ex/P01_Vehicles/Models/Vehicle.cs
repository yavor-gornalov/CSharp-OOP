using Vehicles.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDrivable, IRefuelable
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public abstract double AdditionalConsumtion { get; }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * (FuelConsumption + AdditionalConsumtion);
            if (FuelQuantity < fuelNeeded)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
                return;
            }
            FuelQuantity -= fuelNeeded;
            Console.WriteLine($"{GetType().Name} travelled {distance} km");
        }

        public abstract void Refuel(double quantity);

        public override string ToString() => $"{GetType().Name}: {FuelQuantity:F2}";
    }
}
