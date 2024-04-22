using NeedForSpeed.Models.Car;
using NeedForSpeed.Models.Motorcycle;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var sportsCar = new SportCar(350, 50);
            sportsCar.Drive(4);
            Console.WriteLine($"Remaining fuel: {sportsCar.Fuel}");

            var raceMotorcycle = new RaceMotorcycle(100, 20);
            raceMotorcycle.Drive(2);
            Console.WriteLine($"Remaining fuel: {raceMotorcycle.Fuel}");
        }
    }
}
