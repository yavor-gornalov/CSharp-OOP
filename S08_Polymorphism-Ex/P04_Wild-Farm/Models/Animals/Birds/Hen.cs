
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }
        public override double WeightIncreaseFactor { get; set; } = 0.35;
        public override List<Type> PreferredFoods { get; set; } = new() { typeof(Fruit), typeof(Meat), typeof(Seeds), typeof(Vegetable) };

        public override void ProduceSound() => Console.WriteLine("Cluck");

    }
}
