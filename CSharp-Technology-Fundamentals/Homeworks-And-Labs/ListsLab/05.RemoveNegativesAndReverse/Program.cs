﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                    i = -1;
                }
                if (numbers.Count == 0)
                {
                    Console.WriteLine("empty");
                    break;
                }
            }
            
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));       
            

        }
    }
}
