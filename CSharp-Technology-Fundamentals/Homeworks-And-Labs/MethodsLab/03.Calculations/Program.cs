using System;

namespace _03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string method = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (method)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "substract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }
        }

        static void Add (int firstNum, int secondNum)
        {
            Console.WriteLine (firstNum + secondNum);         
        }
        static void Multiply (int firstNum, int secondNum)
        {
            Console.WriteLine (firstNum * secondNum);
        }
        static void Subtract (int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
        static void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
