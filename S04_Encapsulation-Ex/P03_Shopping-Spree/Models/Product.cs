namespace ShoppingSpree.Models
{
    public class Product
    {
        private string name;
        private double cost;

        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                name = value;
            }
        }

        public double Cost
        {
            get => cost;
            private set
            {
                if (value < 0)
                    throw new Exception("Money cannot be negative");
                cost = value;
            }
        }

        public override string ToString() => Name.ToString();
    }
}
