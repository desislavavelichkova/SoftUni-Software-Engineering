using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            var counts = new SortedDictionary<int, int>();

            foreach (var num in numbers)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (var num in counts)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
            
        }
    }
}
