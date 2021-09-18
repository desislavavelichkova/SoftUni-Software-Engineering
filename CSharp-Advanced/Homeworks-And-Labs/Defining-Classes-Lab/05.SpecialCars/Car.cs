using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            Engine = engine;
            Tires = tires;
        }

        public void Drive(double distance)
        {            
                this.FuelQuantity -= distance * (this.FuelConsumption/100);            
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: { this.Make}\n");
            sb.Append($"Model: { this.Model}\n");
            sb.Append($"Year: { this.Year}\n");
            sb.Append($"HorsePowers: {this.Engine.HorsePower}\n");
            sb.Append($"FuelQuantity: {this.FuelQuantity}");

            return sb.ToString();
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        
    }

}
