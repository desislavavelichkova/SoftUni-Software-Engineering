using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {      

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public void Drive(double distance)
        {
            bool canDrive = this.FuelQuantity - (distance* this.FuelConsumption) > 0;
        if (canDrive)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: { this.Make}\n");
            sb.Append($"Model: { this.Model}\n");
            sb.Append($"Year: { this.Year}\n");
            sb.Append($"Fuel: { this.FuelQuantity:F2}L\n");

            return sb.ToString();
        }
    }     
    
}
