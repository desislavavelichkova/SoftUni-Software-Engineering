using System;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] times = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int midIndex = (times.Length / 2) + 1;

            double leftPlayer = 0;
            double rightPlayer = 0;
           
                for (int i = 0; i < times.Length / 2; i++)
                {
                    if (times[i] == 0)
                    {
                        leftPlayer *= 0.8;
                    }
                    else
                    {
                        leftPlayer += times[i];
                    }
                }
                for (int i = times.Length - 1; i > times.Length / 2; i--)
                {
                    if (times[i] == 0)
                    {
                        rightPlayer *= 0.8;
                    }
                    else
                    {
                        rightPlayer += times[i];
                    }
                }
            
            if (rightPlayer > leftPlayer)
            {

                Console.WriteLine($"The winner is left with total time: {leftPlayer}");
            }
            else if (rightPlayer < leftPlayer)
            {
                Console.WriteLine($"The winner is right with total time: {rightPlayer}");
            }
        }
    }
}
