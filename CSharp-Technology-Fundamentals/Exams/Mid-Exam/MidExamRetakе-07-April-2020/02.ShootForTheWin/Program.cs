﻿using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int count = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int index = int.Parse(input);

                if ( index < 0 || index >= targets.Length || targets[index] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int shotTarget = targets[index];

                targets[index] = -1;
                count++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] == -1)
                    {
                        continue;
                    }
                    if (targets[i] > shotTarget)
                    {
                        targets[i] -= shotTarget;
                    }
                    else 
                    {
                        targets[i] += shotTarget;
                    }                    
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
    }
}
