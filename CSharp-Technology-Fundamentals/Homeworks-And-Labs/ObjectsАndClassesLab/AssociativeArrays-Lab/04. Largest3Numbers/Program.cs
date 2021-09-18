using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)                            
                            .ToArray();
            int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            List<int> largestNumbers = new List<int>();

            for (int i = 0; i < sorted.Length; i++)
            {
                if (i < 3)
                {
                    largestNumbers.Add(sorted[i]);
                }
                else
                {
                    break;
                }   
            }
            
            Console.WriteLine(string.Join(" ", largestNumbers));
        }
    }
}
