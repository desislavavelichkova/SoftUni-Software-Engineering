using System;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                int currentLenght = input[i].Length;

                for (int j = 0; j < currentLenght; j++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
