namespace FakeAxeAndDummy.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using NUnit.Framework;
    using Moq;
    using FakeAxeAndDummy;

    [TestFixture]
    public class HeroTests
    {
        private readonly string _heroName = "Minotaur";
        private readonly int _weaponAttack = 10;
        private readonly int _weaponDurability = 10;
        private readonly int _dummyHealth = 10;
        private readonly int _dummyExperience = 50;

        public Axe Weapon { get; private set; }
        public Hero MythicHero { get; private set; }

        public Dummy Target { get; private set; }

        [SetUp]
        public void Init()
        {
            Weapon = new Axe(_weaponAttack, _weaponDurability);
            MythicHero = new Hero(_heroName, Weapon);
            Target = new Dummy(_dummyHealth, _dummyExperience);
        }

        [Test]
        public void TestHeroConstructor()
        {
            Assert.Multiple(() =>
            {
                Assert.That(MythicHero.Name, Is.EqualTo(_heroName));
                Assert.That(MythicHero.Experience, Is.EqualTo(0));
                Assert.That(MythicHero.Weapon.AttackPoints, Is.EqualTo(_weaponAttack));
                Assert.That(MythicHero.Weapon.DurabilityPoints, Is.EqualTo(_weaponDurability));
            });
        }

        [Test]
        public void TestHeroAttacksTargetShouldInceaseHeroExperiance()
        {
            MythicHero.Attack(Target);

            Assert.Multiple(() =>
            {
                Assert.That(MythicHero.Experience, Is.EqualTo(_dummyExperience));
                Assert.That(Target.Health, Is.EqualTo(0));
                Assert.That(MythicHero.Weapon.DurabilityPoints, Is.EqualTo(_weaponDurability - 1));
            });
        }
    }
}