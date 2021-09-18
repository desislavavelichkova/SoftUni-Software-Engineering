using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horesPower, double fuel)
        {
            HoresPower = horesPower;
            Fuel = fuel;
            
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public int HoresPower { get; set; }
        public double Fuel { get; set; }

        public virtual void Drive(double kilometers)
        {
           this.Fuel -= this.FuelConsumption * kilometers ;
        }
    }
}
