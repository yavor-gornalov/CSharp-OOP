using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Rebel : Human, IBuyer
    {
        private readonly int boughtQuantity = 5;
        public Rebel(string name, int age, string group) : base(name, age)
        {
            Group = group;
        }

        public string Group { get; set; }
        public int Food { get; set; } = 0;

        public void BuyFood() => Food += boughtQuantity;
    }
}
