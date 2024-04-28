using WildFarm.Interfaces;
using WildFarm.Models.Foods;

namespace WildFarm.Factories
{
    public class FoodFactory
    {
        public IFood createFood(params string[] foodTokens)
        {
            string foodType = foodTokens[0];
            int quantity = int.Parse(foodTokens[1]);
            return foodType switch
            {
                "Vegetable" => new Vegetable(quantity),
                "Fruit" => new Fruit(quantity),
                "Meat" => new Meat(quantity),
                "Seeds" => new Seeds(quantity),
                _ => throw new ArgumentException("Invalid food type!"),
            };
        }
    }
}
