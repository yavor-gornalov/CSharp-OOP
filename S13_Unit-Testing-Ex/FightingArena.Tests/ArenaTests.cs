namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ArenaTests
    {
        private Warrior attacker;
        private Warrior defender;
        private Arena blankArena;
        private Arena fightArena;
        [SetUp]
        public void StartUp()
        {
            attacker = new("Predator", 50, 100);
            defender = new("Alien", 35, 75);
            blankArena = new();
            fightArena = new();
            fightArena.Enroll(attacker);
            fightArena.Enroll(defender);
        }

        [Test]
        public void TestConstructor()
        {
            Arena arena = new();
            Assert.AreEqual(arena.Warriors, Array.Empty<Warrior>());
            Assert.AreEqual(0, arena.Count);
        }

        [Test]
        public void TestEnrolWarrior()
        {
            blankArena.Enroll(attacker);
            Assert.AreEqual(1, blankArena.Count);
            Assert.AreEqual(attacker.Name, blankArena.Warriors.First(w => w.Name == attacker.Name).Name);
        }

        [Test]
        public void TestEnrolWarriorWithSameName()
        {
            blankArena.Enroll(attacker);
            var ex = Assert.Throws<InvalidOperationException>(() => blankArena.Enroll(attacker));
            Assert.AreEqual("Warrior is already enrolled for the fights!", ex.Message);
        }

        [Test]
        public void TestFight()
        {
            fightArena.Fight(attacker.Name, defender.Name);

            Assert.AreEqual(65, attacker.HP);
            Assert.AreEqual(25, defender.HP);
        }

        [Test]
        [TestCase("Invalid", "Alien")]
        [TestCase(null, "Alien")]
        public void TestFightWithInvalidAttackerName(string attackerName, string defenderName)
        {
            var ex = Assert.Throws<InvalidOperationException>(() => fightArena.Fight(attackerName, defenderName));
            Assert.AreEqual($"There is no fighter with name {attackerName} enrolled for the fights!", ex.Message);
        }

        [Test]
        [TestCase("Predator", "Invalid")]
        [TestCase("Predator", null)]
        public void TestFightWithInvalidDefenderName(string attackerName, string defenderName)
        {
            var ex = Assert.Throws<InvalidOperationException>(() => fightArena.Fight(attackerName, defenderName));
            Assert.AreEqual($"There is no fighter with name {defenderName} enrolled for the fights!", ex.Message);

        }
    }
}
