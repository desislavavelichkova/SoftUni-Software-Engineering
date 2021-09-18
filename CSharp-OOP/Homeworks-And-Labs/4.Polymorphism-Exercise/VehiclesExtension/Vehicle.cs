using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Vehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumption, double airConditionerModifier, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionerModifier = airConditionerModifier;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity { get; set; }        
        public double FuelConsumption { get; private set; }
        protected virtual double AirConditionerModifier { get; set; }
        public double TankCapacity { get; private set; }

        public void Drive(double distance)
        {
            double currentFuel = (this.FuelConsumption + this.AirConditionerModifier) * distance;
            
            if (currentFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            this.FuelQuantity -= currentFuel;
        }
        public void DriveEmpty(double distance)
        {           

            double currentFuel = this.FuelConsumption * distance;

            if (currentFuel > this.FuelQuantity)
            {
                throw new InvalidOperationException($"{GetType().Name} needs refueling");
            }

            this.FuelQuantity -= currentFuel;
        }

        public virtual void Refuel(double fuelForRefuel)
        {
            if (fuelForRefuel > this.TankCapacity - this.FuelQuantity)
            {
                throw new InvalidOperationException($"Cannot fit {fuelForRefuel} fuel in the tank");
            }

            this.FuelQuantity += fuelForRefuel;
        }
        public virtual string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }

    }
}
