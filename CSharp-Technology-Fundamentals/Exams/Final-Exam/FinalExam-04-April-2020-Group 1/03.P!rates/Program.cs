using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.P_rates
{
    class Program
    {
        static void Main(string[] args)
        {            
            Dictionary<string, int> townGold = new Dictionary<string, int>();
            Dictionary<string, int> townPopulation = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] tokens = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string town = tokens[0];
                int people = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (townGold.ContainsKey(town) && townPopulation.ContainsKey(town))
                {
                    townGold[town] += gold;
                    townPopulation[town] += people;
                }
                else
                {
                    townGold.Add(town, gold);
                    townPopulation.Add(town, people);
                }

                input = Console.ReadLine();
            }

            string comands = Console.ReadLine();

            while (comands != "End")
            {
                string[] cmndArgs = comands.Split("=>",StringSplitOptions.RemoveEmptyEntries);

                string comand = cmndArgs[0];
                string town = cmndArgs[1];

                if (comand == "Plunder")
                {
                    int people = int.Parse(cmndArgs[2]);
                    int gold = int.Parse(cmndArgs[3]);

                    townGold[town] -= gold;
                    townPopulation[town] -= people;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (townGold[town] <= 0 || townPopulation[town] <= 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        townGold.Remove(town);
                        townPopulation.Remove(town);
                    }                    
                }
                else if (comand == "Prosper")
                {
                    int gold = int.Parse(cmndArgs[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        townGold[town] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {townGold[town]} gold.");
                    }

                }

                comands = Console.ReadLine();
            }

            Console.WriteLine($"Ahoy, Captain! There are {townGold.Count} wealthy settlements to go to:");

            foreach (var item in townGold.OrderByDescending(x => x.Value).ThenBy(x =>x.Key))
            {
                int people = townPopulation[item.Key];

                Console.WriteLine($"{item.Key} -> Population: {people} citizens, Gold: {item.Value} kg");
            }
            if (townGold.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }
    }
}
