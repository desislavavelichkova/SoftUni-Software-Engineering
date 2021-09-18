using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> modelMileage = new Dictionary<string, int>();
            Dictionary<string, int> modelFuel = new Dictionary<string, int>();
            int maxFuelInTank = 75;
            int minKilometers = 10000;

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|");
                string model = tokens[0];
                int mileage = int.Parse(tokens[1]);
                int fuel = int.Parse(tokens[2]);

                modelMileage.Add(model, mileage);
                modelFuel.Add(model, fuel);

            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] tokens = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string model = tokens[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(tokens[2]);
                    int neededFuel = int.Parse(tokens[3]);

                    if (neededFuel > modelFuel[model])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        modelMileage[model] += distance;
                        modelFuel[model] -= neededFuel;
                        Console.WriteLine($"{model} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");
                    }
                    if (modelMileage[model] >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {model}!");
                        modelFuel.Remove(model);
                        modelMileage.Remove(model);
                    }
                }
                else if (command == "Refuel")
                {
                    int givenFuel = int.Parse(tokens[2]);
                    int currentFuel = 0;

                    if (modelFuel[model] + givenFuel > maxFuelInTank)
                    {
                        currentFuel = maxFuelInTank - modelFuel[model];
                        modelFuel[model] = maxFuelInTank;                        
                    }
                    else
                    {
                        modelFuel[model] += givenFuel;
                        currentFuel = givenFuel;
                    }
                    Console.WriteLine($"{model} refueled with {currentFuel} liters");
                }
                else if (command == "Revert")
                {
                    int revertedKilometers = int.Parse(tokens[2]);
                    if (modelMileage[model] - revertedKilometers < minKilometers)
                    {
                        modelMileage[model] = minKilometers;                        
                    }
                    else
                    {
                        modelMileage[model] -= revertedKilometers;
                        Console.WriteLine($"{model} mileage decreased by {revertedKilometers} kilometers");
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var car in modelMileage.OrderByDescending(x => x.Value)
                                            .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {modelFuel[car.Key]} lt.");
            }
        }
    }
    
}
