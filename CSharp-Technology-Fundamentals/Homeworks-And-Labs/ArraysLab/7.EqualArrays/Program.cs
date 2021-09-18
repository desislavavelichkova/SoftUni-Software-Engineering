﻿using System;
using System.Linq;

namespace _7.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();
            int[] secondArr = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

            int sumFirstArr = 0;
           

            for (int i = 0; i < firstArr.Length; i++)
            {       
                if (firstArr[i] == secondArr[i])
                {
                    sumFirstArr += firstArr[i];                    
                }
                else if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    Environment.Exit(0);
                }                
            }
            Console.WriteLine($"Arrays are identical. Sum: {sumFirstArr}");
        }
    }
}
