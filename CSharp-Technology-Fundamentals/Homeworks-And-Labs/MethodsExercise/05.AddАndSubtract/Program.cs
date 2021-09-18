using System;

namespace _05.AddАndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int result = SumАndSubtract(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(result);
        }

        private static int SumАndSubtract(int firstNumber, int secondNumber, int thirdNumber)
        {
            int sum = firstNumber + secondNumber;
            int result = sum - thirdNumber;
            return result;

        }
    }
}
