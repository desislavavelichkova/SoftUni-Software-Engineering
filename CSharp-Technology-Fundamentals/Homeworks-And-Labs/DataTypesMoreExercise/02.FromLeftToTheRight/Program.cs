using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input == "")
                {

                }

                Console.WriteLine($"{input} is { dataType } type");
                input = Console.ReadLine();
            }
        }
    }
}
