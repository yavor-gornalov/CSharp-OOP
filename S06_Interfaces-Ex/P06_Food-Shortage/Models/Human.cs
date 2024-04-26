using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Human
    {
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
