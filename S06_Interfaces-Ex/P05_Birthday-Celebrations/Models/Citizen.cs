using BirthdayCelebrations.Interfaces;

namespace BirthdayCelebrations.Models
{
    public class Citizen : Human, IBirthable
    {
        public Citizen(string name, int age, string id, string birthdate) : base(name, age, id)
        {
            Birthdate = birthdate;
        }

        public string Birthdate { get; set; }
    }
}
