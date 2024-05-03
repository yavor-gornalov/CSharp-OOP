namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        private static readonly string _name = "Predator";
        private static readonly int _damage = 50;
        private static readonly int _hp = 100;

        private Warrior predator;
        private Warrior opponent;


        [SetUp]
        public void StartUp()
        {
            predator = new(_name, _damage, _hp);
            //alien = new("Alien", 30, 45);
        }

        [Test]
        public void TestWarriorConstructor()
        {
            Warrior warrior = new(_name, _damage, _hp);

            Assert.AreEqual(_name, warrior.Name);
            Assert.AreEqual(_damage, warrior.Damage);
            Assert.AreEqual(_hp, warrior.HP);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void TestWarriorNameSetterWithIncorrectData(string name)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Warrior(name, _damage, _hp));
            Assert.AreEqual("Name should not be empty or whitespace!", ex.Message);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void TestWarriorDamageSetterWithIncorrectData(int damage)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Warrior(_name, damage, _hp));
            Assert.AreEqual("Damage value should be positive!", ex.Message);
        }

        [Test]
        [TestCase(-1)]
        public void TestWarriorHPSetterWithIncorrectData(int hp)
        {
            var ex = Assert.Throws<ArgumentException>(() => new Warrior(_name, _damage, hp));
            Assert.AreEqual("HP should not be negative!", ex.Message);
        }

        [Test]
        [TestCase("Alien", 25, 75)]

        public void TestWarriorAttackOpponent(string opponentName, int opponentDamage, int opponentHP)
        {
            opponent = new(opponentName, opponentDamage, opponentHP);
            predator.Attack(opponent);

            Assert.AreEqual(predator.HP, _hp - opponentDamage);
            Assert.AreEqual(opponent.HP, opponentHP - predator.Damage);
        }

        [Test]
        [TestCase("Alien", 25, 45)]

        public void TestWarriorKillsOpponent(string opponentName, int opponentDamage, int opponentHP)
        {
            opponent = new(opponentName, opponentDamage, opponentHP);
            predator.Attack(opponent);

            Assert.AreEqual(predator.HP, _hp - opponentDamage);
            Assert.AreEqual(opponent.HP, 0);
        }


        [Test]
        [TestCase("Alien", 25, 30)]

        public void TestWarriorAttacksWeakOpponent(string opponentName, int opponentDamage, int opponentHP)
        {
            opponent = new(opponentName, opponentDamage, opponentHP);

            var ex = Assert.Throws<InvalidOperationException>(() => predator.Attack(opponent));
            Assert.AreEqual("Enemy HP must be greater than 30 in order to attack him!", ex.Message);

        }

        [Test]
        [TestCase("Alien", 25, 30)]

        public void TestWarriorAttacksWithInsufficientHP(string opponentName, int opponentDamage, int opponentHP)
        {
            opponent = new(opponentName, opponentDamage, opponentHP);

            var ex = Assert.Throws<InvalidOperationException>(() => opponent.Attack(opponent));
            Assert.AreEqual("Your HP is too low in order to attack other warriors!", ex.Message);

        }

        [Test]
        [TestCase("Alien", 250, 300)]
        public void TestWeakWarriorAttacksStrongOpponent(string opponentName, int opponentDamage, int opponentHP)
        {
            opponent = new(opponentName, opponentDamage, opponentHP);

            var ex = Assert.Throws<InvalidOperationException>(() => predator.Attack(opponent));
            Assert.AreEqual("You are trying to attack too strong enemy", ex.Message);

        }
    }
}