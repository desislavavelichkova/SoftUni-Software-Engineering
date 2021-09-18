using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmndArgs = input.Split();
                string command = cmndArgs[0];
                

                if (command == "swap")
                {
                    int index1 = int.Parse(cmndArgs[1]);
                    int index2 = int.Parse(cmndArgs[2]);

                    int oldItem = elements[index1];
                    int newItem = elements[index2];

                    elements.RemoveAt(index1);
                    elements.Insert(index1, newItem);
                    elements.RemoveAt(index2);
                    elements.Insert(index2, oldItem);

                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(cmndArgs[1]);
                    int index2 = int.Parse(cmndArgs[2]);

                    int firstIndexElement = elements[index1];
                    int secondIndexElement = elements[index2];

                    firstIndexElement *= secondIndexElement;
                    elements[index1] = firstIndexElement;

                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        elements[i] -= 1;
                    }
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", ", elements));
        }
    }
}
