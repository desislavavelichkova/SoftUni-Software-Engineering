using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
                                

            while (command != "end")
            {
                string[] cndArg = command.Split();

                if (cndArg[0] == "Add")
                {
                    wagons.Add(int.Parse(cndArg[1]));                        
                }
                else
                {
                    int passenger = int.Parse(cndArg[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];
                        bool ifEnoughSpace = currentWagon + passenger <= maxCapacityOfWagon;
                        
                        if (ifEnoughSpace)
                        {
                            wagons[i] += passenger;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }

                Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
