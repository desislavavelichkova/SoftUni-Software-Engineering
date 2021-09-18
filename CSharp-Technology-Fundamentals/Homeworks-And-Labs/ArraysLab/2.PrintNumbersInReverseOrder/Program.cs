using System;
using System.Linq;
namespace _2.PrintNumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
