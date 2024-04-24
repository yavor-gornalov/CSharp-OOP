namespace PizzaCalories.Models
{
    public class Pizza
    {
        private const int MaxToppingsNumber = 10;

        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }

        private Dough Dough { get=> dough; set=> dough = value; }

        public int NumberOfToppings
        {
            get => toppings.Count;
        }

        public double TotalCalories
        {
            get
            {
                double total = Dough.CaloriesPerGram;
                foreach (var topping in toppings)
                    total += topping.CaloriesPerGram;
                return total;
            }
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= MaxToppingsNumber)
                throw new ArgumentException($"Number of toppings should be in range [0..{MaxToppingsNumber}].");
            toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {TotalCalories:F2} Calories.";
        }
    }
}
