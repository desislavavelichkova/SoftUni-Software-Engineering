using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantsRarity = new Dictionary<string, int>();
            Dictionary<string, List<int>> plantsRate = new Dictionary<string, List<int>>();
            Dictionary List<int>


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");

                string plant = input[0];
                int rarity = int.Parse(input[1]);

                if (plantsRarity.ContainsKey(plant))
                {
                    plantsRarity[plant] = rarity;
                }
                else
                {
                    plantsRarity.Add(plant, rarity);
                }
            }

            string inputCommand = Console.ReadLine();
            int countRate = 0;
            double averageRating = 0.00;

            while (inputCommand != "Exhibition")
            {
                string[] tokens = inputCommand.Split(": ");
                string command = tokens[0];
                string[] cmndArgs = tokens[1].Split(" - ");

                string plantName = cmndArgs[0];

                if (command == "Rate")
                {
                    int rating = int.Parse(cmndArgs[1]);

                    if (!plantsRate.ContainsKey(plantName))
                    {
                        plantsRate.Add(plantName, rating);
                        countRate++;
                    }
                    else
                    {
                        plantsRate[plantName] += rating;
                        countRate++;
                        averageRating = plantsRate[plantName] / countRate;
                        plantsAverige[plantName] = averageRating;

                    }
                }
                else if (command == "Update")
                {
                    int newRarity = int.Parse(cmndArgs[1]);
                    plantsRarity[plantName] = newRarity;
                }
                else if (command == "Reset")
                {
                    plantsRate[plantName] = 0;                              
                }
                else
                {
                    Console.WriteLine("error");
                }
                inputCommand = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            //double averageRating = 0.00;

            foreach (var item in plantsRarity.OrderByDescending(x => x.Value))           
            {

                averageRating = plantsRate.Average(x => x.Value);            
                 
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {averageRating:f2}");
            }
        }
    }
}
