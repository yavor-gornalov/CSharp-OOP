using ExplicitInterfaces.Interfaces;
using ExplicitInterfaces.Models;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var citizenInfo = line.Split().ToArray();
                var citizen = new Citizen(
                    name: citizenInfo[0],
                    country: citizenInfo[1],
                    age: int.Parse(citizenInfo[2])
                    );
                IPerson person = citizen;
                IResident resident = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
