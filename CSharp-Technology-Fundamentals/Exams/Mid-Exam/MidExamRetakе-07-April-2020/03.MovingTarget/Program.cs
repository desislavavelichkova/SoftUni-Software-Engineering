using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            string input = Console.ReadLine();
            
            while (input != "End")
            {
                string[] cmndArgs = input.Split(" ");

                string command = cmndArgs[0];
                int index = int.Parse(cmndArgs[1]);
                int value = int.Parse(cmndArgs[2]);

                if (index < 0 || index > targets.Count)
                {
                    if (command == "Add")
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    else if (command == "Stike")
                    {
                        Console.WriteLine("Strike missed!");
                    }

                   input = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "Shoot":
                        targets[index] -= value;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                        break;

                    case "Add":
                        targets.Insert(index, value);
                        break;

                    case "Strike":

                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            input = Console.ReadLine();
                            continue;
                        }
                        for (int i = index - value; i <= index + value; i++)
                        {
                            targets.RemoveAt(index - value);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
