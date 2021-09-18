using System;
using System.Linq;

namespace _01.Nikulden_sCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Finish")
            {
                string[] cmndArgs = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string command = cmndArgs[0];
                if (command == "Replace")
                {
                    string currentChar = cmndArgs[1];
                    string newChar = cmndArgs[2];

                    message = message.Replace(currentChar, newChar);
                    Console.WriteLine(message);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(cmndArgs[1]);
                    int endIndex = int.Parse(cmndArgs[2]);

                    if (startIndex >= 0 && startIndex < message.Length && endIndex >= 0 && endIndex < message.Length)
                    {
                        message = message.Remove(startIndex, endIndex - startIndex);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (command == "Make")
                {
                    string secondCommand = cmndArgs[1];

                    if (secondCommand == "Upper")
                    {
                        message = message.ToUpper();
                    }
                    else if (secondCommand == "Lower")
                    {
                        message = message.ToLower();
                    }
                    Console.WriteLine(message);
                }
                else if (command == "Check")
                {
                    string substring = cmndArgs[1];
                    if (message.Contains(substring))
                    {
                        Console.WriteLine($"Message contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {substring}");
                    }
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(cmndArgs[1]);
                    int endIndex = int.Parse(cmndArgs[2]);

                    if (startIndex >= 0 && startIndex < message.Length && endIndex >= 0 && endIndex < message.Length)
                    {
                        string substring = message.Substring(startIndex, endIndex - startIndex + 1);
                        int sumOfSubstringChars = substring.Sum(x => (int)x);                        
                        Console.WriteLine(sumOfSubstringChars);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
