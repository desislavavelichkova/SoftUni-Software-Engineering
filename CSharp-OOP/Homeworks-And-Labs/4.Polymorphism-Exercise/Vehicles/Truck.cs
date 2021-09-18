using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck:Vehicle
    {
        private const double airConditionerModifier = 1.6;
        private const double tankCapacity = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption, airConditionerModifier)
        {

        }
        public override void Refuel(double fuelForRefuel)
        {            
            base.Refuel(fuelForRefuel * tankCapacity);
        }
    }
}
