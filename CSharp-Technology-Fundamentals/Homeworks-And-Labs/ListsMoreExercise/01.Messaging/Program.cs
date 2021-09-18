using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = Console.ReadLine()                
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();
                      
            string newDigit = "";
            string currentDigit = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int sum = 0;
                while (currentNumber != 0)
                {
                    int r = currentNumber % 10;
                    currentNumber = currentNumber / 10;
                    sum += r;
                }
                                
                if (sum >= 0 && sum < text.Length)
                {
                    currentDigit = text[sum].ToString();
                }
                else
                {
                    currentDigit = text[sum - text.Length].ToString();
                }

                newDigit += currentDigit;
                int index = text.IndexOf(currentDigit);
                text = text.Remove(index, 1);
            }

            Console.Write(newDigit);
        }
    }
}
