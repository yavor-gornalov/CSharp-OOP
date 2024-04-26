using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private readonly string[] availableCorpsNames = { "Airforces", "Marines" };
        private string corpsName;

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corpsName) :
            base(id, firstName, lastName, salary)
        {
            CorpsName = corpsName;
        }

        public string CorpsName
        {
            get => corpsName;
            private set
            {
                if (!availableCorpsNames.Contains(value))
                    throw new ArgumentException("Invalid corps name!");
                corpsName = value;
            }
        }
    }
}
