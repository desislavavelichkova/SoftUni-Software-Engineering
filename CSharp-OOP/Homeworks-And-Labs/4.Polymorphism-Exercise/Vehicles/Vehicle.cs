using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double airConditionerModifier)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionerModifier = airConditionerModifier;
        }

        public double FuelQuantity { get; private set; }
        public double FuelConsumption { get; private set; }
        protected double AirConditionerModifier { get; set; }

        public void Drive(double distance)
        {
            double currentFuel = (this.FuelConsumption + this.AirConditionerModifier) * distance;
            
            if (currentFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            this.FuelQuantity -= currentFuel;
        }
        public virtual void Refuel(double fuelForRefuel)
        {
            this.FuelQuantity += fuelForRefuel;
        }
        public virtual string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }

    }
}
