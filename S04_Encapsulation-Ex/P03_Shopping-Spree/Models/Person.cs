using System;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> bag;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                name = value;
            }
        }
        public double Money
        {
            get => money;
            private set
            {
                if (value < 0)
                    throw new Exception("Money cannot be negative");
                money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag
        {
            get => bag.AsReadOnly();
        }

        public void BuyProduct(Product product)
        {
            if (Money < product.Cost)
            {
                Console.WriteLine($"{Name} can't afford {product.Name}");
                return;
            }
            Money -= product.Cost;
            bag.Add(product);
            Console.WriteLine($"{Name} bought {product}");
        }

        public override string ToString()
        {
            string boughtProducts = Bag.Count > 0 ? string.Join(", ", Bag) : "Nothing bought";
            return $"{Name} - {boughtProducts}";
        }
    }
}
