using FoodShortage.Interfaces;
using FoodShortage.Models;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfBuyers = int.Parse(Console.ReadLine());
            var buyers = new List<IBuyer>();

            for (int i = 0; i < numberOfBuyers; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (tokens.Length)
                {
                    case 3:
                        {
                            var rebel = new Rebel(name: tokens[0], int.Parse(tokens[1]), group: tokens[2]);
                            buyers.Add(rebel);
                            break;
                        }
                    case 4:
                        {
                            var citizen = new Citizen(name: tokens[0], age: int.Parse(tokens[1]), id: tokens[2], birthdate: tokens[3]);
                            buyers.Add(citizen);
                            break;
                        }
                }
            }

            string name;
            while ((name = Console.ReadLine()) != "End")
            {
                IBuyer buyer = buyers.FirstOrDefault(b => b.Name == name);
                if (buyer == null)
                    continue;
                buyer.BuyFood();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
