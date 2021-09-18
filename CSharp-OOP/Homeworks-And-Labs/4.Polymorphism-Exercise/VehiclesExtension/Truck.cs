using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Truck: Vehicle
    {
        private const double airConditionerModifier = 1.6;
        private const double tankConstant = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, airConditionerModifier, tankCapacity * tankConstant)
        {

        }       
    }
}
