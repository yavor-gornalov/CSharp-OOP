using System.Xml.Linq;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int initialPower = 100;
        public Paladin(string name) : base(name, Paladin.initialPower)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} healed for {Power}";
    }
}
