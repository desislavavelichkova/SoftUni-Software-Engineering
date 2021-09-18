using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();



            Func<List<int>, int> minNumber =
                numbers =>
                {
                    int minNum = int.MaxValue;

                    foreach (var num in numbers)
                    {
                        if (num < minNum)
                        {
                            minNum = num;
                        }
                    }

                    return minNum;
                };
                       
            Console.WriteLine(minNumber(numbers));
        }
        
    }
}
