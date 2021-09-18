using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

            Queue<int> stack = new Queue<int>();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            for (int i = 0; i < n; i++)
            {
                stack.Enqueue(numbers[i]);

            }
            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {

                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }

    }
}
