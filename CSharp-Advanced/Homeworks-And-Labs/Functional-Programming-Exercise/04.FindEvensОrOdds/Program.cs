using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensОrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();
            int startIndex = range[0];
            int endIndex = range[1];

            string typeOfNumbers = Console.ReadLine();

            Func<int, int, List<int>> generateRangeNumbers =
                (start, end) =>
                {
                    List<int> nums = new List<int>();

                    for (int i = startIndex; i <= endIndex; i++)
                    {                        
                        nums.Add(i);
                    }
                    return nums;

                };

            List<int> numbers = generateRangeNumbers(startIndex, endIndex);

            Predicate<int> predicate = n => true;

            if (typeOfNumbers == "odd")
            {
                predicate = n =>  n % 2 != 0;
            }
            else if (typeOfNumbers == "even")
            {
                predicate = n => n % 2 == 0;
            }

            Console.WriteLine(string.Join(" ", MyWhere(numbers, predicate)));            
        }

        static List<int> MyWhere (List<int> numbers, Predicate<int> predicate)
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
