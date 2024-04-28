using System.Xml.Linq;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int initialPower = 80;
        public Druid(string name) : base(name, Druid.initialPower)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} healed for {Power}";
    }
}
