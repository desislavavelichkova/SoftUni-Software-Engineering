using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            FactorialOfFirstInt(firstInt);
            FactorialOfSecondInt(secondInt);
            double result = (FactorialOfFirstInt(firstInt) * 1.0) / FactorialOfSecondInt(secondInt) * 1.0;
            Console.WriteLine($"{result:f2}");
        }

        static double FactorialOfFirstInt(int firstInt)
        {
            double firstFactorial = 1;

            for (int i = 1; i <= firstInt; i++)
            {
                firstFactorial *= i;                
            }
            return firstFactorial;
        }
        static double FactorialOfSecondInt(int secondInt)
        {
            double secondFactorial = 1;

            for (int i = 1; i <= secondInt; i++)
            {
                secondFactorial *= i;
            }
            return secondFactorial;
        }
    }
}
