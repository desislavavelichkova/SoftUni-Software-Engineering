using System;

namespace _01.SignОfIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            SignOfIntegerNumber(number);
        }

        static void SignOfIntegerNumber (int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
