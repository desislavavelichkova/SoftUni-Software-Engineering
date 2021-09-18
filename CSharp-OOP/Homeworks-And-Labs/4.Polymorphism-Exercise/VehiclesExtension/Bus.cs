using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus: Vehicle
    {
        private const double airConditionerModifier = 1.4;
        public Bus(double fuelQuantity, double fuelConstumtion, double tankCapacity)
            : base(fuelQuantity, fuelConstumtion, airConditionerModifier, tankCapacity)
        { }        
    }
}
