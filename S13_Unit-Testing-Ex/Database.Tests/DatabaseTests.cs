namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void TestStoringCapacityOfConstructor()
        {
            int[] bigData = new int[17];

            var ex = Assert.Throws<InvalidOperationException>(() => new Database(bigData));
            Assert.That(ex.Message, Is.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void TestFetchMethod()
        {
            Database db = new Database();
            Assert.That(() => db.Fetch(), Is.EqualTo(Array.Empty<int>()));

            db.Add(1);
            Assert.That(() => db.Fetch(), Is.EqualTo(new int[] { 1 }));

            db.Add(2);
            Assert.That(() => db.Fetch(), Is.EqualTo(new int[] { 1, 2 }));
        }

        [Test]
        public void TestAddMethodAddsElementToFirstEmptyCell()
        {
            var data = new int[] { };
            var expected = new int[] { 5 };

            Database db = new(data);
            db.Add(5);

            Assert.That(db.Count, Is.EqualTo(1));
            Assert.That(() => db.Fetch(), Is.EqualTo(expected));
        }

        [Test]
        public void TestAddMethodThrowsExceptionWhenDatabaseIsFull()
        {
            var data = Enumerable.Range(1, 16).ToArray();

            Database db = new(data);

            var ex = Assert.Throws<InvalidOperationException>(() => db.Add(17));
            Assert.That(ex.Message, Is.EqualTo("Array's capacity must be exactly 16 integers!"));

        }

        [Test]
        public void TestRemoveMethodRemovesLastElement()
        {
            var data = new int[] { 1, 2 };
            var expected = new int[] { 1 };

            Database db = new(data);
            db.Remove();

            Assert.That(() => db.Fetch(), Is.EqualTo(expected));
        }

        [Test]
        public void TestRemoveMethodThrowsException()
        {
            Database db = new();

            var ex = Assert.Throws<InvalidOperationException>(() => db.Remove());
            Assert.AreEqual("The collection is empty!", ex.Message);
        }
    }
}
