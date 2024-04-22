namespace Restaurant.Models.Beverage.HotBeverage
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine)
            : base(name, CoffeePrice, CoffeeMilliliters)
        {
            Caffeine = caffeine;
        }

        public static double CoffeeMilliliters { get; set; } = 50;
        public static decimal CoffeePrice { get; set; } = 3.5m;
        public double Caffeine { get; set; }
    }
}
