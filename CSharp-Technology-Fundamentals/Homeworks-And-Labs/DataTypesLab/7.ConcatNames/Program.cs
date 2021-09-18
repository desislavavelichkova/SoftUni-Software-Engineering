using System;

namespace _7.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string position = Console.ReadLine();

            Console.WriteLine($"{firstName}{position}{lastName}");
        }
    }
}
