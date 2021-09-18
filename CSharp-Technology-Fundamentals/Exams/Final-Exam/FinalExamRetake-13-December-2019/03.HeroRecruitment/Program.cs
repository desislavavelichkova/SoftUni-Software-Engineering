using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> heroAndSpellName = new Dictionary<string, List<string>>();
            
            while (input != "End")
            {
                string[] cmndArgs = input.Split(" ");
                string command = cmndArgs[0];
                string heroName = cmndArgs[1];

                if (command == "Enroll")
                {
                    if (heroAndSpellName.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                    else
                    {
                        heroAndSpellName.Add(heroName, new List<string>());
                    }
                }
                else if (command == "Learn")
                {
                    string spellName = cmndArgs[2];
                    if (heroAndSpellName.ContainsKey(heroName) && !heroAndSpellName[heroName].Contains(spellName))
                    {
                        heroAndSpellName[heroName].Add(spellName);
                        
                    }
                    else if (heroAndSpellName.ContainsKey(heroName) && heroAndSpellName[heroName].Contains(spellName))
                    {
                        Console.WriteLine($"{heroName} has already learnt {spellName}.");
                    }
                    else if(!heroAndSpellName.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                else if (command == "Unlearn")
                {
                    string spellName = cmndArgs[2];

                    if (heroAndSpellName.ContainsKey(heroName))
                    {
                        if (heroAndSpellName[heroName].Contains(spellName))
                        {
                            heroAndSpellName[heroName].Remove(spellName);                           
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }   
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Heroes:");

            foreach (var item in heroAndSpellName.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
