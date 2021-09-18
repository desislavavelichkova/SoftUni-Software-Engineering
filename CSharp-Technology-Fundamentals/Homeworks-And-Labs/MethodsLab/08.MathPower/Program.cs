using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            double result = PowerNum(number, powerNumber);
            Console.WriteLine(result);
        }
        static double PowerNum(double num, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;                
            }
            return result;
        }
    }
}
