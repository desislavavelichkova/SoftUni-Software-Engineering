using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endIndex = int.Parse(Console.ReadLine());

            List<int> dividers = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            List<int> numbers = new List<int>();
            Func<int, int, bool> predicate =
                (num, d) => num % d == 0;

            for (int i = 1; i <= endIndex; i++)
            {
                if (dividers.All(d => predicate(i, d)))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
