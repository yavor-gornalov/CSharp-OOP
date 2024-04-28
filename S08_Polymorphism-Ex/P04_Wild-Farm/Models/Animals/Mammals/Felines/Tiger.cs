
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightIncreaseFactor { get; set; } = 1.0;
        public override List<Type> PreferredFoods { get; set; } = new() { typeof(Meat) };

        public override void ProduceSound() => Console.WriteLine("ROAR!!!");
    }
}
