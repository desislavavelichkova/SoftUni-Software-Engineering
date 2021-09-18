using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lenghtNumbers = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            int n = lenghtNumbers[0];
            int m = lenghtNumbers[1];

            HashSet<double> firstLine = new HashSet<double>();
            HashSet<double> secondLine = new HashSet<double>();

            int count = 0;
            for (int i = 0; i < n + m; i++)
            {
                
                double number = double.Parse(Console.ReadLine());
                count++;
                if (count <= n)
                {
                    firstLine.Add(number);
                }
                else
                {
                    if (firstLine.Contains(number))
                    {
                        secondLine.Add(number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", secondLine));

        }
    }
}
