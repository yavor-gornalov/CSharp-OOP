namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private static List<Person> personsList;
        private Database personsDB;
        private Database emptyDb;

        [SetUp]
        public void StartUp()
        {
            emptyDb = new Database();
            personsList = new List<Person>();
            for (long i = 1; i <= 16; i++)
            {
                personsList.Add(new Person(i, $"Person{i}"));
            }
            personsDB = new Database(personsList.ToArray());
        }

        [Test]
        public void TestConstructorWithoutData()
        {
            Database db = new();
            Assert.AreEqual(0, db.Count);
        }

        [Test]
        public void TestConstructorWithData()
        {
            Database db = new(personsList.ToArray());
            Assert.AreEqual(personsList.Count, db.Count);
        }

        [Test]
        public void TestConstructorWithBigDataThrowsException()
        {
            personsList.Add(new Person(17, "Person17"));
            var ex = Assert.Throws<ArgumentException>(() => new Database(personsList.ToArray()));
            Assert.AreEqual("Provided data length should be in range [0..16]!", ex.Message);
        }

        [Test]
        public void TestFindByUsername()
        {
            Assert.That(() => personsDB.FindByUsername("Person1").UserName, Is.EqualTo("Person1"));
        }

        [Test]
        public void TestFindByUsernameWithoutTargetName()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => personsDB.FindByUsername(string.Empty));
            Assert.True(ex.Message.Contains("Username parameter is null!"));
        }

        [Test]
        public void TestFindByUsernameUnexistingUser()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => personsDB.FindByUsername("Person0"));
            Assert.AreEqual("No user is present by this username!", ex.Message);
        }

        [Test]
        public void TestFindUserById()
        {
            Assert.True(personsDB.FindById(1).Id == 1);
        }

        [Test]
        public void TestFindUserByIdWithNegativeIdValue()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => personsDB.FindById(-1));
            Assert.True(ex.Message.Contains("Id should be a positive number!"));
        }
        [Test]
        public void TestFindUserByIdWithNotPresentId()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => personsDB.FindById(100));
            Assert.True(ex.Message.Contains("No user is present by this ID!"));
        }

        [Test]
        public void TestRemoveFormEmptyDB()
        {
            Assert.Throws<InvalidOperationException>(() => emptyDb.Remove());
        }

        [Test]
        public void TestAddPersonToFullDB()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => personsDB.Add(new Person(100, "Person100")));
            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);
        }

        [Test]
        public void TestAddPersonWithExistingName()
        {
            personsDB.Remove();
            var ex = Assert.Throws<InvalidOperationException>(() => personsDB.Add(new Person(100, "Person1")));
            Assert.AreEqual("There is already user with this username!", ex.Message);
        }

        [Test]
        public void TestAddPersonWithExistingId()
        {
            personsDB.Remove();
            var ex = Assert.Throws<InvalidOperationException>(() => personsDB.Add(new Person(1, "Person100")));
            Assert.AreEqual("There is already user with this Id!", ex.Message);
        }

        [Test]
        public void TestAddPersonHappyPath()
        {
            emptyDb.Add(new Person(1, "Person1"));
            Assert.AreEqual(1, emptyDb.Count);
        }
    }
}