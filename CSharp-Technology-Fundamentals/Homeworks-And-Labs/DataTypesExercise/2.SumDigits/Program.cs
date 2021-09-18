using System;
using System.Xml.Schema;

namespace _2.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigit = 0;
            int digit = 0;

            while (number > 0)
            {
                digit = number % 10;
                number = number / 10;
                sumOfDigit += digit;
                continue;
            }
            Console.WriteLine(sumOfDigit);
        }
    }
}
