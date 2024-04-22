namespace Restaurant.Models.Food.MainDish
{
    public class Fish : MainDish
    {
        public static double FishGrams { get; set; } = 22;
        public Fish(string name, decimal price) : base(name, price, FishGrams)
        {
        }
    }
}
