namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int initialPower = 80;
        public Rogue(string name) : base(name, Rogue.initialPower)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} hit for {Power} damage";
    }
}
