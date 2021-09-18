using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleCatalog = new List<Vehicle>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = tokens[0].ToLower();
                string model = tokens[1];
                string color = tokens[2];
                int horsePower = int.Parse(tokens[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                vehicleCatalog.Add(vehicle);

                input = Console.ReadLine();
            }

            string comand = Console.ReadLine();

            while (comand != "Close the Catalogue")
            {
                string modelVehicle = comand;

                Vehicle printCar = vehicleCatalog.First(x => x.Model == modelVehicle);

                Console.WriteLine(printCar);

                comand = Console.ReadLine();
            }

            List<Vehicle> cars = vehicleCatalog.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucks = vehicleCatalog.Where(x => x.Type == "truck").ToList();

            double totalCars = cars.Count;
            double totalTrucks = trucks.Count;

            double totalCarsHorsePower = cars.Sum(x => x.Horsepower);
            double totalTrucksHorsePower = trucks.Sum(x => x.Horsepower);

            double averageCarHorsePower = 0.00;
            double averageTrucksHorsePower = 0.00;
            if (totalCars > 0)
            {
                averageCarHorsePower = totalCarsHorsePower / totalCars;

            }
            if (totalTrucks > 0)
            {
                averageTrucksHorsePower = totalTrucksHorsePower / totalTrucks;

            }
            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsePower:f2}.");

        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type.ToLower();
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}

