using System;
using System.Linq;
using System.Collections.Generic;


namespace _01.CountCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] words = Console.ReadLine().ToCharArray();

            Dictionary<char, int> count = new Dictionary<char, int>();
                        
                    foreach (var symbol in words)
                    {
                
                        if (count.ContainsKey(symbol) == false && symbol != ' ')
                        {
                            count.Add(symbol, 1);
                        }

                        else if(count.ContainsKey(symbol) == true && symbol != ' ')
                        {
                            count[symbol]++;
                        }
                    }
            
            foreach (var chars in count)
            {
                Console.WriteLine($"{chars.Key} -> {chars.Value}");
            }     
        }
    }
}
