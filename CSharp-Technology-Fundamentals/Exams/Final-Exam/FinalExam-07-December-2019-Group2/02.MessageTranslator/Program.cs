using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string pattern = @"!([A-Z][a-z]{2,})!\:\[([A-z]{8,})\]";

                Match match = Regex.Match(input, pattern);
                
                if (match.Success)
                {
                    string message = match.Groups[2].Value;
                    List<int> listOfChars = new List<int>();

                    for (int j = 0; j < message.Length; j++)
                    {
                        listOfChars.Add((int)message[j]);
                    }
                    Console.WriteLine($"{match.Groups[1].Value}: {string.Join(" ", listOfChars)}");
                }
                else
                {
                    Console.WriteLine($"The message is invalid");
                }

            }
        }
    }
}
