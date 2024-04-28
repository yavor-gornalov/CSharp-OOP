
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightIncreaseFactor { get; set; } = 0.3;
        public override List<Type> PreferredFoods { get; set; } = new() { typeof(Meat), typeof(Vegetable) };

        public override void ProduceSound() => Console.WriteLine("Meow");
    }
}
