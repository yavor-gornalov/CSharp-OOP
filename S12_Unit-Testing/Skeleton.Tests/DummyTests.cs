using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Axe axe = new(5, 10);
            Dummy dummy = new(10, 10);

            axe.Attack(dummy);
            Assert.That(dummy.Health, Is.EqualTo(5));
        }

        [Test]
        public void DeadDummyThrowsAnExceptionIfAttacked()
        {
            Axe axe = new(5, 10);
            Dummy dummy = new(0, 10);

            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new(0, 10);

            Assert.That(() => dummy.GiveExperience(), Is.EqualTo(10));
        }

        [Test]
        public void AliveDummyCanNotGiveXP()
        {
            Dummy dummy = new(10, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}