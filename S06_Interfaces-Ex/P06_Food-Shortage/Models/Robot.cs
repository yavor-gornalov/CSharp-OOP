using FoodShortage.Interfaces;

namespace FoodShortage.Models
{
    public class Robot : Iidentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; set; }
    }
}
