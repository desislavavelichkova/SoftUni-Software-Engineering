using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            string pattern = @"(#|@)([A-z]{3,})\1\1([A-z]{3,})\1";

            List<string> mirror = new List<string>();

            MatchCollection matchesWord = Regex.Matches(text, pattern);

            if (matchesWord.Count > 0)
            {
                Console.WriteLine($"{matchesWord.Count} word pairs found!");

                for (int i = 0; i < matchesWord.Count; i++)
                {
                    string firstWord = matchesWord[i].Groups[2].Value;
                    string secondWord = matchesWord[i].Groups[3].Value;
                    string reversedSecondWord = "";

                    for (int j = secondWord.Length - 1; j >= 0; j--)
                    {
                        reversedSecondWord += secondWord[j];
                    }

                    if (firstWord == reversedSecondWord)
                    {
                        string mirrorString = firstWord + " <=> " + secondWord;
                        mirror.Add(mirrorString);
                    }
                }
                if (mirror.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {                    
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirror));
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
