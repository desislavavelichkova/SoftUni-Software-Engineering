using System;
using System.Linq;
using System.Xml.Schema;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);                        
        }

        static int GetMultipleOfEvenAndOdds(int num)
        {
            int result = GetSumOfEven(num) * GetSumOfOdd(num);
            return result;
        }

        static int GetSumOfEven(int num)
        {
            int sumOfEven = 0;
                        
            while (num != 0)
            {
                int currentNum = num % 10;
                if (currentNum % 2 == 0)
                {
                    sumOfEven += currentNum;
                }
                num -= currentNum;
                num /= 10;
            }

            return sumOfEven;            
        }
        static int GetSumOfOdd(int num)
        {
            int sumOfOdd = 0;

            while (num != 0)
            {
                int currentNum = num % 10;

                if (currentNum % 2 == 1)
                {
                    sumOfOdd += currentNum;
                }
                num -= currentNum;
                num /= 10;
            }
            return sumOfOdd;
        }

    }
}
