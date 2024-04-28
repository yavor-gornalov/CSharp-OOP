using WildFarm.Interfaces;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightIncreaseFactor { get; set; } = 0.25;
        public override List<Type> PreferredFoods { get; set; } = new() { typeof(Meat) };

        public override void ProduceSound() => Console.WriteLine("Hoot Hoot");
    }
}
