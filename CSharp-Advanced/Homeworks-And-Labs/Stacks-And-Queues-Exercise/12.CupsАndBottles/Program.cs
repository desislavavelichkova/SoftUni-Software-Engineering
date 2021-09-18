using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsАndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            int[] bottleWater = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();
            Queue<int> cupsLeft = new Queue<int>();
            Stack<int> bottles = new Stack<int>(bottleWater);
            int wastedWater = 0;

            for (int i = 0; i < cups.Length; i++)
            {
                if (bottles.Count == 0)
                {
                    cupsLeft.Enqueue(cups[i]);
                    continue;
                }
                int cupsValue = cups[i];
                int bottleValue = bottles.Peek();

                if (cupsValue <= bottleValue)
                {
                    wastedWater += bottleValue - cupsValue;
                    bottles.Pop();                    
                }
                else
                {
                    cupsValue -= bottleValue;
                    cups[i] = cupsValue;
                    i--;
                    bottles.Pop();                    
                }
                
            }
            if (cupsLeft.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsLeft)}");
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
