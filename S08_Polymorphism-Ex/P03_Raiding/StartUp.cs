using Raiding.Interfaces;
using Raiding.Models;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var heroes = new List<IHero>();
            var heroFactory = new HeroFactory();

            int armySize = int.Parse(Console.ReadLine());


            while (heroes.Count < armySize)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                try
                {
                    IHero hero = heroFactory.CreateHero(heroType, heroName);
                    heroes.Add(hero);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                bossPower -= ((BaseHero)hero).Power;
            }

            if (bossPower <= 0)
                Console.WriteLine("Victory!");
            else
                Console.WriteLine("Defeat...");
        }
    }
}
