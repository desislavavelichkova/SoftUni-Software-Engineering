using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> predicate = x => x % n != 0;           

            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));

        }
        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (var currNum in numbers)
            {
                if (predicate(currNum))
                {
                    newNumbers.Add(currNum);
                }
            }

            newNumbers.Reverse();
            return newNumbers;
        }
    }
}
