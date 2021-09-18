using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Drivers.Contracts;
using System;

namespace EasterRaces.Models.Drivers
{
    public class Driver : IDriver
    {
        private string name;        
        private int winRace;        

        public Driver(string name)
        {
            Name = name;            
            this.winRace = winRace;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) && value.Length < 5)
                {
                    throw new ArgumentException($"Name {Name} cannot be less than 5 symbols.");
                }
                this.name = value;
            }
        }

        public ICar Car { get; private set; }        

        public int NumberOfWins { get; private set; }

        public bool CanParticipate => this.Car != null;        

        public void AddCar(ICar car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("Car cannot be null.");
            }
            this.Car = car;
        }

        public void WinRace()
        {
            NumberOfWins += 1;
        }
    }
}
