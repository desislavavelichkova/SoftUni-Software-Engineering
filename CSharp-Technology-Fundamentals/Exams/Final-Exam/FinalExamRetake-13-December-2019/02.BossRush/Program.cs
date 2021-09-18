using System;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            string pattern = @"\|([A-Z]{4,})\|:#([A-Za-z]+\s[A-Za-z]+)#";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                // "{boss name}, The {title}
                // >> Strength: { length of the name}
                // >> Armour: { length of the title}                

                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups[1]}, The {match.Groups[2]}");
                    Console.WriteLine($">> Strength: {match.Groups[1].Length}");
                    Console.WriteLine($">> Armour: {match.Groups[2].Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }

            }
        }
    }
}
