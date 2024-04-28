using WildFarm.Interfaces;

namespace WildFarm.Models.Foods
{
    public abstract class Food : IFood
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; set; }
    }
}
