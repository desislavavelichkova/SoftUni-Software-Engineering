using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            int digit = 0;
            bool isFind = false;
            for (int num = 1; num <= number; num++)
            {
                digit = num;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }
                isFind = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", digit, isFind);
                sumOfDigits = 0;
                num = digit;
            }

        }
    }
}
