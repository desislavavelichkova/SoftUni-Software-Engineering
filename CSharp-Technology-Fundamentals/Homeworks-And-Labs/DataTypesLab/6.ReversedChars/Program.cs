﻿using System;

namespace _6.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            char thirdCharacter = char.Parse(Console.ReadLine());
            Console.WriteLine($"{thirdCharacter} {secondCharacter} {firstCharacter}");
        }
    }
}
