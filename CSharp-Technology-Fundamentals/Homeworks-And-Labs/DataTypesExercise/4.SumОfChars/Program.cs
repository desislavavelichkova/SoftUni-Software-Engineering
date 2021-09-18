using System;

namespace _4.SumОfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int sumOfChar = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                char latinAlphabet = char.Parse(Console.ReadLine());
                sumOfChar += latinAlphabet;
            }
            Console.WriteLine($"The sum equals: {sumOfChar}");
        }
    }
}
