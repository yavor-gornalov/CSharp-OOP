using WildFarm.Interfaces;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal, ICanEat, ICanMakeSound
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; } = 0;
        public abstract double WeightIncreaseFactor { get; set; }
        public abstract List<Type> PreferredFoods { get; set; }



        public void Eat(IFood food)
        {
            if (!PreferredFoods.Contains(food.GetType()))
                throw new ArgumentException($"{GetType().Name} does not eat {food.GetType().Name}!");

            FoodEaten += food.Quantity;
            Weight += food.Quantity * WeightIncreaseFactor;
        }

        public abstract void ProduceSound();
    }
}
