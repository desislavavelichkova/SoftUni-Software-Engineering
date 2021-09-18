using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] cmndArg = input.Split(" ");
                string command = cmndArg[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(cmndArg[1]);
                    int endIndex = int.Parse(cmndArg[2]);

                    items.Add(cmndArg[2]);

                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
