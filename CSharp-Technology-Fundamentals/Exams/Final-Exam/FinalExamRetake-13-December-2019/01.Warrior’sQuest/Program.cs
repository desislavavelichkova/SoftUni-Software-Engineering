using System;
using System.Linq;

namespace _01.Warrior_sQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "For Azeroth")
            {
                string[] cmndArgs = input.Split(" ");
                string command = cmndArgs[0];

                if (command == "GladiatorStance")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "DefensiveStance")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "Dispel")
                {
                    int index = int.Parse(cmndArgs[1]);
                    string letter = cmndArgs[2];

                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, letter);
                        text = text.Remove(index + 1, 1);

                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Dispel too weak.");
                    }                    
                }
                else if (command == "Target")
                {
                    string secondCommand = cmndArgs[1];
                    string substring = cmndArgs[2];
                    string secondSubstring = cmndArgs[3];

                    if (text.Contains(substring))
                    {
                        text = text.Replace(substring, secondSubstring);
                        Console.WriteLine(text);
                    }                    
                }
                else if (command == "Target Remove")
                {
                    string substring = cmndArgs[1];
                    int index = text.IndexOf(substring);
                    text = text.Remove(index, substring.Length);
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                input = Console.ReadLine();
            }
            
        }
    }
}
