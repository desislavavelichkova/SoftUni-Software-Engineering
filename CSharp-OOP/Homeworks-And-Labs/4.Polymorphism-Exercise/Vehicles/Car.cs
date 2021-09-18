using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car: Vehicle
    {
        private const double airConditionerModifier = 0.9;
        public Car(double fuelQuantity, double fuelConstumtion)
            : base(fuelQuantity, fuelConstumtion, airConditionerModifier)
        { }

    }
}
