using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carTokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var car = new Car(carTokens[0], carTokens[1]);

            var truckTokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var truck = new Truck(truckTokens[0], truckTokens[1]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                string command = tokens[0];
                string vehicleType = tokens[1];
                double amount = double.Parse(tokens[2]);

                Vehicle vehicle = null;
                if (vehicleType == "Car")
                    vehicle = car;
                else if (vehicleType == "Truck")
                    vehicle = truck;

                if (vehicle == null)
                    continue;

                if (command == "Drive")
                    vehicle.Drive(amount);
                else if (command == "Refuel")
                    vehicle.Refuel(amount);
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
