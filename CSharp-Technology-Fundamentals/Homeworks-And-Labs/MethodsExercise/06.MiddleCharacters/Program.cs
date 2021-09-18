using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 0)
            {
                string chars = MiddleCharacterOfEven(input);
                Console.WriteLine(chars);
            }
            if (input.Length % 2 != 0)
            {
                string chars = MiddleCharacterOfOdd(input);
                Console.WriteLine(chars);
            }
        }

        static string MiddleCharacterOfEven(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index - 1,2);
            return chars;
        }
        static string MiddleCharacterOfOdd(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);
            return chars;
        }

    }
}
