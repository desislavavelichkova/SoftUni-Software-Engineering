using System;
using System.Linq;

namespace _6.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else if (currentNumber % 2 != 0)
                {
                    sumOdd += currentNumber;
                }
            }

            int result = sumEven - sumOdd;            
            Console.WriteLine(result);
        }
    }
}
