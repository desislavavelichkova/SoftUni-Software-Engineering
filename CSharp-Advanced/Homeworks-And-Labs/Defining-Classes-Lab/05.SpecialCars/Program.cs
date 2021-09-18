using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string inputTire = Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();

            while (inputTire != "No more tires")
            {
                string[] tireInformation = inputTire.Split(" ");

                var tire = new Tire[4]
                {
                new Tire(int.Parse(tireInformation[0]), double.Parse(tireInformation[1])),
                new Tire(int.Parse(tireInformation[2]), double.Parse(tireInformation[3])),
                new Tire(int.Parse(tireInformation[4]), double.Parse(tireInformation[5])),
                new Tire(int.Parse(tireInformation[6]), double.Parse(tireInformation[7])),
                };

                tires.Add(tire);

                inputTire = Console.ReadLine();
            }

            string inputEngines = Console.ReadLine();

            List<Engine> engines = new List<Engine>();

            while (inputEngines != "Engines done")
            {
                string[] data = inputEngines
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine engine = new Engine(int.Parse(data[0]), double.Parse(data[1]));
                engines.Add(engine);

                inputEngines = Console.ReadLine();
            }

            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();

            while (input != "Show special")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(data[0], data[1], int.Parse(data[2]), double.Parse(data[3]), double.Parse(data[4]), engines[int.Parse(data[5])], tires[int.Parse(data[6])]);
                cars.Add(car);

                input = Console.ReadLine();
            }

            List<Car> filterCars = cars.Where(cars => cars.Year >= 2017 && cars.Engine.HorsePower > 330).ToList();

            foreach (var car in filterCars)
            {
                double sumOfPressure = 0;
                foreach (var tire in car.Tires)
                {
                    sumOfPressure += tire.Pressure;
                }

                if (sumOfPressure >= 9 && sumOfPressure <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }

            }
        }
    }

}


