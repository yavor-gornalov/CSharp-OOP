namespace PizzaCalories.Models
{
    public class Dough
    {
        private readonly Dictionary<string, double> flourTypes = new()
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };
        private readonly Dictionary<string, double> bakingTechniques = new()
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        private const double defaultCaloriesPerGram = 2.0;
        private const double MinWeight = 1;
        private const double MaxWeight = 200;


        private string type;
        private string technique;
        private double weight;

        public Dough(string type, string technique, double weight)
        {
            Type = type;
            Technique = technique;
            Weight = weight;
        }

        private string Type
        {
            get => type;
            set
            {
                if (!flourTypes.ContainsKey(value.ToLower()))
                    throw new Exception("Invalid type of dough.");
                type = value;
            }
        }

        private string Technique
        {
            get => technique;
            set
            {
                if (!bakingTechniques.ContainsKey(value.ToLower()))
                    throw new Exception("Invalid type of dough.");
                technique = value;
            }
        }

        private double Weight
        {
            get => weight;
            set
            {
                if (value < MinWeight || value > MaxWeight)
                    throw new Exception($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                weight = value;
            }
        }

        public double CaloriesPerGram
        {
            get => defaultCaloriesPerGram * Weight * flourTypes[Type.ToLower()] * bakingTechniques[Technique.ToLower()];
        }
    }
}
