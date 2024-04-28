namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int initialPower = 100;
        public Warrior(string name) : base(name, Warrior.initialPower)
        {
        }

        public override string CastAbility() => $"{GetType().Name} - {Name} hit for {Power} damage";
    }
}
