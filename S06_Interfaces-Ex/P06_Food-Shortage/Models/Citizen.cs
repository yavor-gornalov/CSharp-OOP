using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Citizen : Human, Iidentifiable, IBirthable, IBuyer
    {
        private readonly int boughtQuantity = 10;
        public Citizen(string name, int age, string id, string birthdate) : base(name, age)
        {
            Id = id;
            Birthdate = birthdate;
        }

        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; } = 0;

        public void BuyFood() => Food += boughtQuantity;
    }
}
