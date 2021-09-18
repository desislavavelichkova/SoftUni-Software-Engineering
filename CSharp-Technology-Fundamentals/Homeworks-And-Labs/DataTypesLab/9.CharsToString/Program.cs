using System;

namespace _9.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCharecter = char.Parse(Console.ReadLine());
            char secondCharecter = char.Parse(Console.ReadLine());
            char thirdCharecter = char.Parse(Console.ReadLine());

            Console.WriteLine($"{firstCharecter}{secondCharecter}{thirdCharecter}");
            
        }
    }
}
