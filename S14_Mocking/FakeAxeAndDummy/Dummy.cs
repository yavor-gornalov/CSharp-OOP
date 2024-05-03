namespace FakeAxeAndDummy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Dummy : ITarget
    {
        private int health;
        private int experience;

        public Dummy(int health, int experience)
        {
            Health = health;
            Experience = experience;
        }

        public int Health { get; set; }

        public int Experience { get; set; }

        public void TakeAttack(int attackPoints)
        {
            if (IsDead())
                throw new InvalidOperationException("Dummy is dead.");

            Health -= attackPoints;
        }

        public int GiveExperience()
        {
            if (!IsDead())
                throw new InvalidOperationException("Target is not dead.");

            return Experience;
        }

        public bool IsDead() => Health <= 0;
    }
}