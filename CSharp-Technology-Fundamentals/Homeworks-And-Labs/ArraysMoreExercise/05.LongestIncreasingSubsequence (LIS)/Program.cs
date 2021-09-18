using System;
using System.Collections.Generic;

namespace _05.LongestIncreasingSubsequence__LIS_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int firstNumber = 0;
            int secondNumber = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                //string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                firstNumber = int.Parse(arr[i]);

                if (arr.Length == 1)
                {                    
                    numbers.Add(firstNumber);
                }

                else
                {
                    secondNumber = int.Parse(arr[i + 1]);

                    if (firstNumber < secondNumber)
                    {
                        numbers.Add(firstNumber);                       
                    }                    
                }                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
