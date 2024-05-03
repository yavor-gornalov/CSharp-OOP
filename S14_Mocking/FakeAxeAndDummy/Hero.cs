namespace FakeAxeAndDummy
{
    public class Hero
    {
        private string name;
        private int experience;
        private IWeapon weapon;

        public Hero(string name, IWeapon weapon)
        {
            Name = name;
            Experience = 0;
            Weapon = weapon;
        }

        public string Name { get; private set; }

        public int Experience { get; private set; }

        public IWeapon Weapon { get; private set; }

        public void Attack(ITarget target)
        {
            Weapon.Attack(target);

            if (target.IsDead())
                Experience += target.GiveExperience();
        }
    }
}