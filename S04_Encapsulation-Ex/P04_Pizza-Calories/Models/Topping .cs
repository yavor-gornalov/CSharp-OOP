namespace PizzaCalories.Models
{
    public class Topping
    {
        private readonly Dictionary<string, double> toppingTypes = new()
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };
        private const double defaultCaloriesPerGram = 2.0;
        private const double MinWeight = 1;
        private const double MaxWeight = 50;

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        private string Type { 
            get => type;
            set {
                if (!toppingTypes.ContainsKey(value.ToLower()))
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                type = value;
            } }

        private double Weight
        {
            get => weight;
            set
            {
                if (value < MinWeight || value > MaxWeight)
                    throw new Exception($"{Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
                weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get => defaultCaloriesPerGram * Weight * toppingTypes[Type.ToLower()];
        }

    }
}
