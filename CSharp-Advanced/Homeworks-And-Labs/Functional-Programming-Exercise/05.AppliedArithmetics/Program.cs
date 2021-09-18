using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            string command = Console.ReadLine();
            
            Func<int, int> artithmeticFunc = num => num;
            Action<List<int>> print = 
                nums => Console.WriteLine(string.Join(" ", nums));

            while (command != "end")
            {
                Predicate<int> predicate = n => true;

                if (command == "add")
                {
                    artithmeticFunc = num => num + 1;
                    numbers = numbers.Select(artithmeticFunc).ToList();
                }
                else if (command == "multiply")
                {
                    artithmeticFunc = num => num * 2;
                    numbers = numbers.Select(artithmeticFunc).ToList();
                }
                else if (command == "subtract")
                {
                    artithmeticFunc = num => num - 1;
                    numbers = numbers.Select(artithmeticFunc).ToList();
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
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
            return newNumbers;
        }
    }
}
