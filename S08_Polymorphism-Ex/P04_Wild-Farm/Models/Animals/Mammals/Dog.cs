
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double WeightIncreaseFactor { get; set; } = 0.4;
        public override List<Type> PreferredFoods { get; set; } = new() { typeof(Meat) };

        public override void ProduceSound() => Console.WriteLine("Woof!");

    }
}
