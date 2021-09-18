using System;

namespace _01.SmallestОfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int smallestNumber = SmallestNumber(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine(smallestNumber);

        }
        static int SmallestNumber(int numOne, int numTwo, int numThree)
        {
            int result = 0;
            if (numOne <= numTwo && numOne <= numThree)
            {
                result = numOne;
            }
            else if (numTwo <= numOne && numTwo <= numThree)
            {
                result = numTwo;
            }
            else if (numThree <= numOne && numThree <= numTwo)
            {
                result = numThree;
            }
            return result;
        }
    }
}
