using System;

namespace _5.PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
