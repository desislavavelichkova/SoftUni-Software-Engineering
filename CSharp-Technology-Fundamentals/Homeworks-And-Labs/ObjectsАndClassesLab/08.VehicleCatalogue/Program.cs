using System;
using System.Collections.Generic;

namespace _08.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] information = input.Split("/");

                string type = information[0];
                string brand = information[1];
                string model = information[2];
                int horsePowerOrWeight = int.Parse(information[3]);

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePowerOrWeight;
                    cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = horsePowerOrWeight;
                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Cars:");
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck truck in trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class CatalogVehicle
    {
        public List<Car> Cars { get; set; }

        public CatalogVehicle(List<Car> cars)
        {
            Cars = cars;
        }
        
        public List<Truck> Trucks { get; set; }
        public CatalogVehicle(List<Truck> trucks)
        {
            Trucks = trucks;
        }
    }
}
