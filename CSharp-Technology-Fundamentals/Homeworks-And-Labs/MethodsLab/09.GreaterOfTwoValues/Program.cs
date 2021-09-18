using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    GetMaxInt(firstNumber, secondNumber);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    GetMaxChar(firstChar, secondChar);
                    break;
                case "string":
                    string firstText = Console.ReadLine();
                    string secondText = Console.ReadLine();
                    GetMaxString(firstText, secondText);
                    break;
            }

        }
        private static void GetMaxInt(int firstNumber, int secondNumber)
           
        {
            if (firstNumber >= secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine(secondNumber);
            }
        }

        private static void GetMaxChar(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                Console.WriteLine(firstChar);
            }
            else if (firstChar < secondChar)
            {
                Console.WriteLine(secondChar);
            }
        }

        private static void GetMaxString(string firstString, string secondString)
        {
            char[] firstChar = firstString.ToCharArray();
            char[] secondChar = secondString.ToCharArray();

            int valueFirstString = 0;
            int valueSecondString = 0;

            for (int i = 0; i < firstString.Length - 1; i++)
            {
                valueFirstString += firstChar[i];
            }

            for (int i = 0; i < secondString.Length - 1; i++)
            {
                valueSecondString += secondChar[i];
            }

            if (valueFirstString >= valueSecondString)
            {
                Console.WriteLine(firstString);
            }

            else if (valueFirstString < valueSecondString)
            {
                Console.WriteLine(secondString);
            }
        }
    }
}
