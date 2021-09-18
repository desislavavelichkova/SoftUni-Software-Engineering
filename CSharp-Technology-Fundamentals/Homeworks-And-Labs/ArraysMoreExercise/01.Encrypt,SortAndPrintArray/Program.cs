using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Encrypt_SortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, int> inputAndSum = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (   input[j] == 65 || input[j] == 69 
                        || input[j] == 73 || input[j] == 79
                        || input[j] == 85 || input[j] == 97 
                        || input[j] == 101|| input[j] == 105 
                        || input[j] == 111|| input[j] == 117 )
                    {
                        sum += (input[j] * input.Length);
                    }
                    else
                    {
                        sum +=(input[j] / input.Length);
                    }
                }
                inputAndSum.Add(input, sum);
            }
            foreach (var input in inputAndSum.OrderBy(s => s.Value))
            {
                Console.WriteLine($"{input.Value}");
            }

        }
    }
}
