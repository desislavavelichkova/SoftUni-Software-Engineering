using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfNames = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
            Dictionary<string, int> dictionaryOfNames = new Dictionary<string, int>();

            foreach (var name in listOfNames)
            {
                dictionaryOfNames.Add(name, 0);
            }

            string patternName = @"[\W\d]";
            string patternDistance = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, patternName, "");
                string distance = Regex.Replace(input, patternDistance, "");
                
                int sum = 0;

                foreach (var digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;
                }

                if (dictionaryOfNames.ContainsKey(name))
                {
                    dictionaryOfNames[name] += sum;
                }

                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var item in dictionaryOfNames.OrderByDescending(x => x.Value))
            {
                string output = string.Empty;
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                
                Console.WriteLine($"{count++}{text} place: {item.Key}");

                if (count == 4)
                {
                    break;
                }
            }            
        }
    }
}
