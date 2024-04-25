using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Models;

namespace BirthdayCelebrations
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            var birthables = new List<IBirthable>();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (tokens[0])
                {
                    case "Citizen":
                        {
                            var citizen = new Citizen(name: tokens[1], age: int.Parse(tokens[2]), id: tokens[3], birthdate: tokens[4]);
                            birthables.Add(citizen);
                            break;
                        }
                    case "Pet":
                        {
                            var pet = new Pet(name: tokens[1], birthdate: tokens[2]);
                            birthables.Add(pet);
                            break;
                        }
                }
            }

            string birthYear = Console.ReadLine();
            foreach (var birthable in birthables.Where(b => b.Birthdate.EndsWith(birthYear)))
                birthable.PrintBirthdate();
        }
    }
}
