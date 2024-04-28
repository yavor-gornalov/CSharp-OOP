
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override double WeightIncreaseFactor { get; set; } = 0.1;
        public override List<Type> PreferredFoods { get; set; } = new() { typeof(Fruit), typeof(Vegetable) };

        public override void ProduceSound() => Console.WriteLine("Squeak");
    }
}
