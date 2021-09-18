using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            raceEntry = new RaceEntry();
        }

        [Test]
        public void Counter_IsZeroByDefault()
        {
            Assert.That(raceEntry.Counter, Is.Zero);
        }

        [Test]

        public void Counter_Increases_WhenAddingDriver()
        {
            raceEntry.AddDriver(new UnitDriver("Emma", new UnitCar("Tesla", 300, 200)));
            Assert.That(raceEntry.Counter, Is.EqualTo(1));
        }

        [Test]

        public void AddDriverException_WhenDriverIsNUll()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.raceEntry.AddDriver(null));

        }
        [Test]

        public void AddDriverException_WhenDriverIsExist()
        {
            var driverName = "Emma";
            var driver = new UnitDriver("Emma", new UnitCar("Tesla", 300, 200));
            raceEntry.AddDriver(driver);
            var secondDriver = new UnitDriver("Emma", new UnitCar("Tesla", 455, 200));

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(secondDriver));           

        }

        [Test]
        public void AddDriver_ChechDriverAdded()
        {
            var driverName = "Emma";
            var driver = new UnitDriver(driverName, new UnitCar("Tesla", 300, 200)); 
            string result = raceEntry.AddDriver(driver);
            string expectedResult = $"Driver {driverName} added in race.";

            Assert.That(expectedResult, Is.EqualTo(result));
        }

        [Test]
        
        public void CalculateAverageHorsePower_ThrowException_WhenMinParticipantsAreLess()
        {
            Assert.Throws<InvalidOperationException>(() => this.raceEntry.CalculateAverageHorsePower());

            var driver = new UnitDriver("Emma", new UnitCar("Tesla", 300, 200));
            raceEntry.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() => this.raceEntry.CalculateAverageHorsePower());
        }

        [Test]

        public void CalculateAverageHorsePower_Resul_WhenMinParticipantsAreMore()
        {
            
            var driver1 = new UnitDriver("Emma1", new UnitCar("Tesla", 344, 200));
            var driver2 = new UnitDriver("Emma2", new UnitCar("Tesla", 678, 200));
            var driver3 = new UnitDriver("Emma3", new UnitCar("Tesla", 302, 200));
            raceEntry.AddDriver(driver1);
            raceEntry.AddDriver(driver2);
            raceEntry.AddDriver(driver3);

            double expected = (driver1.Car.HorsePower +
                              driver2.Car.HorsePower +
                              driver3.Car.HorsePower) / 3.0;

            double actual = raceEntry.CalculateAverageHorsePower();

            Assert.That((expected), Is.EqualTo(actual));
        }
    }
}