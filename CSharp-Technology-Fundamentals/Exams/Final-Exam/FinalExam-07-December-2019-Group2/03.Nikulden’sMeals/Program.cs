using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Nikulden_sMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> guestList = new Dictionary<string, List<string>>();
            int unlikedMeal = 0;

            while (input != "Stop")
            {
                string[] cmndArgs = input.Split("-");
                string command = cmndArgs[0];
                string guest = cmndArgs[1];
                string meal = cmndArgs[2];

                if (command == "Like")
                {
                    if (!guestList.ContainsKey(guest))
                    {
                        guestList.Add(guest, new List<string>());
                        guestList[guest].Add(meal);
                    }
                    else if (guestList.ContainsKey(guest) && !guestList[guest].Contains(meal))
                    {
                        guestList[guest].Add(meal);
                    }
                }
                else if (command == "Unlike")
                {
                    if (!guestList.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (guestList.ContainsKey(guest) && !guestList[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        unlikedMeal++;
                        guestList[guest].Remove(meal);
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in guestList.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ",item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeal}");
        }
    }
}
