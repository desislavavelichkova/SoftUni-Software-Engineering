using System;

namespace _04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string newInput = string.Empty;
            for (int i = input.Length-1; i >= 0; i--)
            {
                newInput += input[i];                
            }
            Console.Write(newInput);
        }
    }
}
