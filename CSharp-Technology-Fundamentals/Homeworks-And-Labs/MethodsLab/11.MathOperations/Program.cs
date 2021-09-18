using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());
            double result = Calculate(firstNumber, @operator, secondNumber);
            Console.WriteLine(result);

            static double Calculate(double firstNum, string calculateOperator, double secondNum)
            {
                double result = 0d;
                switch (calculateOperator)
                {
                    case "/":
                        result = firstNum / secondNum;                        
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        break;
                    case "+":
                        result = firstNum + secondNum;
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        break;
                }
                return result;
            }
        }
    }
}
