using System;
using System.Collections.Generic;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbers = new List<int>();
            List<char> leters = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 48 && input[i] <= 57)
                {
                    int number = (int)Char.GetNumericValue(input[i]);
                    numbers.Add(number);
                }
                else
                {
                    leters.Add(input[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            List<char> newLeters = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                
                        
            }
            Console.Write(string.Join("", leters));
        }
    }
}
