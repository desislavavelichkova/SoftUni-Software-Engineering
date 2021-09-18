using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (!chars.ContainsKey(currentSymbol))
                {
                    chars.Add(currentSymbol, 1);
                }
                else
                {
                    chars[currentSymbol]++;
                }
            }
            foreach (var symbol in chars.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
