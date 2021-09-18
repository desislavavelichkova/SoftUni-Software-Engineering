using EasterRaces.Models.Cars;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Contracts
{
    public class ChampionshipController : IChampionshipController
    {
               
        private DriverRepository driverRepository;
        private CarRepository carRepository;
        private RaceRepository raceRepository;

        public ChampionshipController()
        {
            driverRepository = new DriverRepository();
            carRepository = new CarRepository();
            raceRepository = new RaceRepository();
        }


        public string AddCarToDriver(string driverName, string carModel)
        {
            IDriver driver = driverRepository.GetByName(driverName);
            ICar car = carRepository.GetByName(carModel);

            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            if (car == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }           
                driver.AddCar(car);
                return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException($"Race { raceName } could not be found.");
            }
            if (driverRepository.GetByName(driverName) == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            else
            {
                IDriver driver = driverRepository.GetByName(driverName);
                IRace race = raceRepository.GetByName(raceName);

                race.AddDriver(driver);
                return $"Driver {driverName} added in {raceName} race.";
            }
        }

        public string CreateCar(string type, string model, int horsePower)
        {            
            if (carRepository.GetByName(type) != null)
            {
                throw new ArgumentException("Car {model} is already created.");
            }

            ICar car = null;
            if (type == "Muscle")
            {
                 car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                 car = new SportsCar(model, horsePower);
            }
            carRepository.Add(car);

            return $"{car.GetType().Name} {model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            if (driverRepository.GetByName(driverName) != null)
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }

            Driver driver = new Driver(driverName);
            driverRepository.Add(driver);           
           
            return $"Driver {driverName} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            if (raceRepository.GetByName(name) != null)
            {
                throw new InvalidOperationException($"Race {name} is already create.");
            }

            Race race = new Race(name, laps);
            
            raceRepository.Add(race);

            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            var race = raceRepository.GetByName(raceName);

            if (raceRepository.GetByName(raceName) == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            int driversCount = raceRepository.GetByName(raceName).Drivers.Count;

            if (driversCount < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            IDriver[] winners = race.Drivers.OrderByDescending(x => x.Car.CalculateRacePoints(race.Laps)).Take(3).ToArray();
            IDriver firstDriver = winners[0];
            IDriver secondDriver = winners[1];
            IDriver thirdDriver = winners[2];

            raceRepository.Remove(race);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Driver {firstDriver.Name} wins {raceName} race.");
            sb.AppendLine($"Driver {secondDriver.Name} is second in {raceName} race.");
            sb.AppendLine($"Driver {thirdDriver.Name} is third in {raceName} race.");

            return sb.ToString().TrimEnd();
        }
    }
}
