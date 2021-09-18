using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            RangeCharacters(firstChar, secondChar);
        }
        static void RangeCharacters(char firstChar, char lastChar)
        {
            if (firstChar > lastChar)
            {
                char first = lastChar;
                lastChar = firstChar;
                firstChar = first;                
            }
            for (int i = firstChar + 1; i < lastChar; i++)
            {                
                Console.Write((char)i + " ");
            }
        }
    }
}
