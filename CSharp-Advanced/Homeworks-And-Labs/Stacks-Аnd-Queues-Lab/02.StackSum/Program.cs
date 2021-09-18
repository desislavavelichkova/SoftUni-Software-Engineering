using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            string input = Console.ReadLine().ToLower();
            Stack<int> stackNumbers = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stackNumbers.Push(numbers[i]);
            }

            while (input != "end")
            {
                string[] cmndArgs = input.Split();
                string command = cmndArgs[0].ToLower();

                if (command == "add")
                {
                    int firstNumber = int.Parse(cmndArgs[1]);
                    int secondNumber = int.Parse(cmndArgs[2]);
                    stackNumbers.Push(firstNumber);
                    stackNumbers.Push(secondNumber);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(cmndArgs[1]);
                    if (stackNumbers.Count > count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackNumbers.Pop();
                        }
                    }                    
                }
                input = Console.ReadLine().ToLower();
            }
            int sum = stackNumbers.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
