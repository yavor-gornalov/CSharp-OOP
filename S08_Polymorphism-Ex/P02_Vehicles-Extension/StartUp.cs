using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var carTokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var car = new Car(carTokens[0], carTokens[1], carTokens[2]);

            var truckTokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var truck = new Truck(truckTokens[0], truckTokens[1], truckTokens[2]);

            var busTokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            var bus = new Bus(busTokens[0], busTokens[1], busTokens[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                string command = tokens[0];
                string vehicleType = tokens[1];
                double amount = double.Parse(tokens[2]);

                Vehicle vehicle = null;
                switch (vehicleType)
                {
                    case "Car": { vehicle = car; break; }
                    case "Truck": { vehicle = truck; break; }
                    case "Bus": { vehicle = bus; break; }
                }

                if (vehicle == null)
                    continue;

                switch (command)
                {
                    case "Drive": { vehicle.Drive(amount); break; }
                    case "DriveEmpty": { ((Bus)vehicle).DriveEmpty(amount); break; }
                    case "Refuel": { vehicle.Refuel(amount); break; }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
