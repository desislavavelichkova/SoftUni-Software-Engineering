using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmArg = command.Split();
                string firstIndex = cmArg[0];
                int element = int.Parse(cmArg[1]);
                if (firstIndex == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if (firstIndex == "Insert")
                {
                    int index = int.Parse(cmArg[2]);
                    numbers.Insert(index, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
