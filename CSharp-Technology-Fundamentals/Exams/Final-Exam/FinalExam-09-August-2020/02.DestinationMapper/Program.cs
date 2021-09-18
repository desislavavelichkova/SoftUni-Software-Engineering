using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})\1";

            MatchCollection mathesdestinations = Regex.Matches(input, pattern);
            List<string> destinations = new List<string>();

            foreach (Match town in mathesdestinations)
            {
                if (!destinations.Contains(town.Groups[2].Value))
                {
                    destinations.Add(town.Groups[2].Value);
                }                
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {destinations.Sum(x => x.Length)}");
        }
    }
}
