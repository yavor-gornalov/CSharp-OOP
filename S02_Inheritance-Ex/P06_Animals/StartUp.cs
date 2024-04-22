using Animals.Models;
using Animals.Models.Cats;
using Animals.Models.Dogs;
using Animals.Models.Frogs;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>(); 
            while (true)
            {
                string animalType = Console.ReadLine();
                if (animalType == "Beast!") break;

                string line = Console.ReadLine();
                if (line == "Beast!") break;

                string[] tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
               
                try
                {
                    switch (animalType)
                    {
                        case "Dog":
                            {
                                var dog = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                                animals.Add(dog);
                                break;
                            }
                        case "Frog":
                            {
                                var frog = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                                animals.Add(frog);
                                break;
                            }
                        case "Cat":
                            {
                                var cat = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                                animals.Add(cat);
                                break;
                            }
                        case "Kitten":
                            {
                                var cat = new Kitten(tokens[0], int.Parse(tokens[1]));
                                animals.Add(cat);
                                break;
                            }
                        case "Tomcat":
                            {
                                var cat = new Tomcat(tokens[0], int.Parse(tokens[1]));
                                animals.Add(cat);
                                break;
                            }
                    }
                } catch(Exception) {
                    Console.WriteLine("Invalid input!");
                }

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal);
                }
            }
        }
    }
}
