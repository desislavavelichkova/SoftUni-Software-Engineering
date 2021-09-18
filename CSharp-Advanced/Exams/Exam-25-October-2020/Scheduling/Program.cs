using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> tasks = new Stack<int>(Console.ReadLine()
                                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(int.Parse)
                                                        .ToArray());

            Queue<int> threads = new Queue<int>(Console.ReadLine()
                                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                             .Select(int.Parse)
                                             .ToArray());
            int taskValueToKill = int.Parse(Console.ReadLine());
            int threadValue = 0;
            while (true)
            {
                int taskValue = tasks.Peek();
                threadValue = threads.Peek();
                if (taskValueToKill == taskValue)
                {
                    tasks.Pop();                    
                    break;
                }

                if (threadValue >= taskValue)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (threadValue < taskValue)
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine($"Thread with value {threadValue} killed task {taskValueToKill}");
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
