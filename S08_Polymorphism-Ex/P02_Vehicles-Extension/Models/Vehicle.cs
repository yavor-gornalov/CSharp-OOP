using Vehicles.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDrivable, IRefuelable
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = tankCapacity < fuelQuantity ? 0 : fuelQuantity; ;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        private double TankFreeSpace { get => TankCapacity - FuelQuantity; }

        public abstract double AdditionalConsumtion { get; set; }

        public abstract double RefuelFactor { get; }


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
        public void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            double refuelQuantity = quantity * RefuelFactor;
            if (refuelQuantity > TankFreeSpace)
            {
                Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
                return;
            }
            FuelQuantity += refuelQuantity;

        }
        public override string ToString() => $"{GetType().Name}: {FuelQuantity:F2}";
    }
}
