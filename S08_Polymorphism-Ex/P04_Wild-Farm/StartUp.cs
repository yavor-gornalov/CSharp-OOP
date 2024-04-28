using WildFarm.Factories;
using WildFarm.Interfaces;
using WildFarm.Models.Animals;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>();
            var animalFactory = new AnimalFactory();
            var foodFactory = new FoodFactory();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                IAnimal animal = null;
                try
                {
                    var animalTokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    animal = animalFactory.createAnimal(animalTokens);


                    line = Console.ReadLine();
                    var foodTokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    IFood food = foodFactory.createFood(foodTokens);

                    ((ICanMakeSound)animal).ProduceSound();
                    ((ICanEat)animal).Eat(food);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

                animals.Add(animal);
            }
            foreach (var animal in animals)
                Console.WriteLine(animal);
        }
    }
}
