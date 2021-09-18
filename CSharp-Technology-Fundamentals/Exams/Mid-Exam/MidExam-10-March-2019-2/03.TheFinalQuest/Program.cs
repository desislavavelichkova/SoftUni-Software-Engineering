using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> instruction = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

            string input = Console.ReadLine();

            while(input != "Stop")
            {
                string[] cmndArgd = input.Split(" ").ToArray();
                string command = cmndArgd[0];

                if (command == "Delete")
                {
                    int index = int.Parse(cmndArgd[1]);

                    if (index >= 0 && index < instruction.Count - 1)
                    {                        
                        instruction.RemoveAt(index + 1);
                    }
                }
                else if (command == "Swap")
                {
                    string firstWord = cmndArgd[1];
                    string secondWord = cmndArgd[2];

                    if (instruction.Contains(firstWord) && instruction.Contains(secondWord))
                    {
                        int firstIndex = instruction.IndexOf(firstWord);
                        int secondIndex = instruction.IndexOf(secondWord);

                        instruction.Insert(secondIndex, firstWord);
                        instruction.RemoveAt(secondIndex + 1);

                        instruction.Insert(firstIndex, secondWord);
                        instruction.RemoveAt(firstIndex + 1);
                            
                    }
                }
                else if (command == "Put")
                {
                    string word = cmndArgd[1];
                    int index = int.Parse(cmndArgd[2]) - 1;

                    if (index >= 0 && index < instruction.Count)
                    {
                        instruction.Insert(index, word);
                    }
                    if (index == instruction.Count)
                    {
                        instruction.Add(word);
                    }
                }
                else if (command == "Sort")
                {
                    instruction.Sort((a, b) => b.CompareTo(a));                

                }
                else if (command == "Replace")
                {
                    string firstWord = cmndArgd[1];
                    string secondWord = cmndArgd[2];

                    if (instruction.Contains(secondWord))
                    {
                        int indexOfSecondWord = instruction.IndexOf(secondWord);
                        instruction.Insert(indexOfSecondWord, firstWord);
                        instruction.Remove(secondWord);
                    }
                }

                    input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", instruction));
        }
    }
}
