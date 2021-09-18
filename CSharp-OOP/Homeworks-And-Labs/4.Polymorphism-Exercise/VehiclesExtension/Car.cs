using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car: Vehicle
    {
        private const double airConditionerModifier = 0.9;
        public Car(double fuelQuantity, double fuelConstumtion, double tankCapacity)
            : base(fuelQuantity, fuelConstumtion, airConditionerModifier, tankCapacity)
        { }

    }
}
