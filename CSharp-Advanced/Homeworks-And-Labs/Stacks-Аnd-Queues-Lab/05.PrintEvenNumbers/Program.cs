﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenNumbers.Enqueue(input[i]);
                    //Console.WriteLine(string.Join(", ", evenNumbers.Dequeue()));
                }
            }
            
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
