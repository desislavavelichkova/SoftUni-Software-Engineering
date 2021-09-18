using EasterRaces.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Models.Cars
{
    public class Car : ICar
    {
        private string model;
        private int horsePower;
        private int maxHorsePower;
        private int minHorsePower;
        private double cubicCentimeters;

        public Car(string model, int horsePower, double cubicCentimeters,
                    int minHorsePower, int maxHorsePower)
        {
            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;
            minHorsePower = minHorsePower;
            maxHorsePower = maxHorsePower;

        }

        public string Model
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException($"Model {Model} cannot be less than 4 symbols.");
                }
                this.model = value;
            }
        }

        public virtual int HorsePower
        {
            get => this.horsePower;
            private set
            {
                if (value < this.minHorsePower && value > this.maxHorsePower)
                {
                    throw new ArgumentException($"Invalid horse power: {HorsePower}.");
                }
                
                this.horsePower = value;
            }
        }

        public double CubicCentimeters
        {
            get => this.cubicCentimeters;
            private set
            {
                this.cubicCentimeters = value;
            }
        }

        public double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps;
        }

    }
}
