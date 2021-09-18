using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsAndSynonyns = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordsAndSynonyns.ContainsKey(word) == false)
                {
                    wordsAndSynonyns.Add(word, new List<string>() {synonym});
                }

                else
                {
                    wordsAndSynonyns[word].Add(synonym);
                }
            }

            foreach (var words in wordsAndSynonyns)
            {
                Console.WriteLine($"{words.Key} - {string.Join(", ", words.Value)}");
            }


        }
    }
}
