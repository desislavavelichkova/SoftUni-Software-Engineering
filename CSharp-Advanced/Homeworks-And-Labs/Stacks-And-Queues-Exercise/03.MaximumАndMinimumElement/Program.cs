using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumАndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "1")
                {
                    int x = int.Parse(input[1]);

                    stack.Push(x);
                }
                else if (input[0] == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }

                }
                else if (input[0] == "3" && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (input[0] == "4" && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
