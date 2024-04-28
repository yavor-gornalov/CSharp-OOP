using WildFarm.Interfaces;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Mammals;
using WildFarm.Models.Animals.Mammals.Felines;

namespace WildFarm.Factories
{
    public class AnimalFactory
    {
        public IAnimal createAnimal(params string[] tokens)
        {
            string animalType = tokens[0];
            string name = tokens[1];
            double weight = double.Parse(tokens[2]);

            switch (animalType)
            {
                case "Owl":
                    {
                        double wingSize = double.Parse(tokens[3]);
                        return new Owl(name, weight, wingSize);
                    }
                case "Hen":
                    {
                        double wingSize = double.Parse(tokens[3]);
                        return new Hen(name, weight, wingSize);
                    }
                case "Mouse":
                    {
                        string livingRegion = tokens[3];
                        return new Mouse(name, weight, livingRegion);
                    }
                case "Dog":
                    {
                        string livingRegion = tokens[3];
                        return new Dog(name, weight, livingRegion);
                    }
                case "Cat":
                    {
                        string livingRegion = tokens[3];
                        string breed = tokens[4];
                        return new Cat(name, weight, livingRegion, breed);
                    }
                case "Tiger":
                    {
                        string livingRegion = tokens[3];
                        string breed = tokens[4];
                        return new Tiger(name, weight, livingRegion, breed);
                    }

                default: throw new ArgumentException("Invalid animal type!");
            }
        }
    }
}
