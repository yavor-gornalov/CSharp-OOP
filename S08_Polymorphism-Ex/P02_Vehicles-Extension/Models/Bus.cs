namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double AdditionalConsumtion { get; set; } = 1.4;

        public override double RefuelFactor => 1;

        public void DriveEmpty(double distance)
        {
            AdditionalConsumtion = 0;
            Drive(distance);
        }
    }
}
