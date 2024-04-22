namespace Restaurant.Models.Food.Dessert
{
    public class Cake : Dessert
    {
        private const double CakeGrams = 22;
        private const double CakeCalories = 1000;
        private const decimal CakePrice = 5m;
        public Cake(string name)
            : base(name, CakePrice, CakeGrams, CakeCalories)
        {
        }
    }
}
