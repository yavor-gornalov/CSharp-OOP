using Raiding.Interfaces;

namespace Raiding.Models
{
    public class HeroFactory
    {
        public IHero CreateHero(string heroType, string heroName)
        {
            return heroType switch
            {
                "Druid" => new Druid(heroName),
                "Paladin" => new Paladin(heroName),
                "Rogue" => new Rogue(heroName),
                "Warrior" => new Warrior(heroName),
                _ => throw new Exception("Invalid hero!"),
            };
        }
    }
}
