namespace Animals.Models
{
    public class Animal
    {
        public string Name { get; private set; }
        public string FavouriteFood { get; private set; }

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf() => $"I am {Name} and my fovourite food is {FavouriteFood}";
    }
}
