using System;

namespace _4.ReverseArrayОfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            string[] items = value.Split();

            for (int i = items.Length; i > 0; i--)
            {
                Console.Write(items[i-1] + " ");
            }

        }
    }
}
