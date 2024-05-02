namespace CarManager.Tests 
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private const string make = "BMW";
        private const string model = "E46";
        private const double fuelConsumption = 6.3;
        private const double fuelCapacity = 63.0;

        private Car testCar;

        [SetUp]
        public void StartUp()
        {
            testCar = new(make, model, fuelConsumption, fuelCapacity);
        }

        [Test]
        public void TestConstructorHappyPath()
        {
            Car car = new(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        [Test]
        public void TestConstructorBlankMakeThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car("", model, fuelConsumption, fuelCapacity));
            Assert.AreEqual("Make cannot be null or empty!", ex.Message);
        }
        [Test]
        public void TestConstructorBlankModelThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car(make, "", fuelConsumption, fuelCapacity));
            Assert.AreEqual("Model cannot be null or empty!", ex.Message);
        }

        [Test]
        public void TestConstructorZeroOrLessConsumptionThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car(make, model, 0, fuelCapacity));
            Assert.AreEqual("Fuel consumption cannot be zero or negative!", ex.Message);
        }

        [Test]
        public void TestConstructorZeroOrLessFuelCapacityThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, 0));
            Assert.AreEqual("Fuel capacity cannot be zero or negative!", ex.Message);
        }

        [Test]
        public void TestRefuelHappyPath()
        {
            testCar.Refuel(50);
            Assert.AreEqual(50, testCar.FuelAmount);
        }

        [Test]
        public void TestRefuelWithZeroOrLessQuantity()
        {
            var ex = Assert.Throws<ArgumentException>(() => testCar.Refuel(0));
            Assert.AreEqual("Fuel amount cannot be zero or negative!", ex.Message);
        }

        [Test]
        public void TestRefuelWithMoreQuantityThanCapacity()
        {
            testCar.Refuel(100);
            Assert.AreEqual(fuelCapacity, testCar.FuelAmount);
        }

        [Test]
        public void TestDriveHappyPath()
        {
            testCar.Refuel(100);
            testCar.Drive(100);
            Assert.AreEqual(56.7, testCar.FuelAmount);
        }

        [Test]
        public void TestDriveWithInsufficientFuel()
        {
            testCar.Refuel(100);
            var ex = Assert.Throws<InvalidOperationException>(() => testCar.Drive(1001));
            Assert.AreEqual("You don't have enough fuel to drive!", ex.Message);
        }

    }
}