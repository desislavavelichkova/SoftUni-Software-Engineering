using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> bandAndTime = new Dictionary<string, int>();
            Dictionary<string, List<string>> bandAndMembers = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] cmndArgs = input.Split("; ");               

                string command = cmndArgs[0];
                string bandName = cmndArgs[1];

                if (command == "Add")
                {
                    string[] members = cmndArgs[2].Split(", ").ToArray();

                    if (bandAndMembers.ContainsKey(bandName) && bandAndTime.ContainsKey(bandName))
                    {
                        for (int i = 0; i < members.Length; i++)
                        {
                            string currentMember = members[i];

                            if (!bandAndMembers[bandName].Contains(currentMember))
                            {
                                bandAndMembers[bandName].Add(currentMember);
                            }
                        }
                    }
                    else if (!bandAndMembers.ContainsKey(bandName) && !bandAndTime.ContainsKey(bandName))
                    {
                        bandAndMembers.Add(bandName, new List<string>());
                        bandAndTime.Add(bandName, 0);

                        for (int i = 0; i < members.Length; i++)
                        {
                            string currentMember = members[i];

                            if (!bandAndMembers[bandName].Contains(currentMember))
                            {
                                bandAndMembers[bandName].Add(currentMember);
                            }
                        }
                    }                    
                }
                else if (command == "Play")
                {
                    int time = int.Parse(cmndArgs[2]);

                    if (bandAndTime.ContainsKey(bandName))
                    {
                        bandAndTime[bandName] += time;
                    }
                    else
                    {
                        bandAndTime.Add(bandName, time);
                        bandAndMembers.Add(bandName, new List<string>());
                    }
                }
                input = Console.ReadLine();
            }

            string finalInput = Console.ReadLine();
            int totalTime = bandAndTime.Select(x => x.Value).Sum();

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in bandAndTime.OrderByDescending(x => x.Value)
                                            .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            if (bandAndMembers.ContainsKey(finalInput))
            {
                Console.WriteLine($"{finalInput}");

                for (int i = 0; i < bandAndMembers[finalInput].Count; i++)
                {
                    Console.WriteLine($"=> {bandAndMembers[finalInput][i]}");
                }                
            }
            
        }
    }
}
