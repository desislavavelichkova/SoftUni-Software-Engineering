using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string patternEmoji = @"(:{2}|(\*{2}))([A-Z][a-z]{2,})\1";
            string patternNumbers = @"\d";

            Regex regNumber = new Regex(patternNumbers);
            Regex regEmoji = new Regex(patternEmoji);

            MatchCollection matchesEmoji = Regex.Matches(input, patternEmoji);
            
            long coolTreshold = 1; 
                
                regNumber.Matches(input)
                         .Select(x => x.Value)
                         .Select(int.Parse)
                         .ToList()
                         .ForEach(x => coolTreshold *= x);

            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in matchesEmoji)
            {
                long coolIndex = emoji.Value
                                        .Substring(2, emoji.Value.Length - 4)
                                        .ToCharArray()
                                        .Sum(x => (int)x);

                if (coolIndex > coolTreshold)
                {
                    coolEmojis.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{matchesEmoji.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
