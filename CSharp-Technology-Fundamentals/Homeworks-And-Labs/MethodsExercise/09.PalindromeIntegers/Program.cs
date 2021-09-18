using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            
            while (input != "END")
            {
                if (input.Length % 2 == 0)
                {
                    PalindromeIntegersEvent(input);
                }
                
                else if (input.Length %2 != 0 )
                {
                    PalindromeIntegersOdd(input);
                }
                input = Console.ReadLine();
            }
            if (input == "END")
            {
                Environment.Exit(0);
            }
        }

        static void PalindromeIntegersEvent(string input)
        {
            bool isFound = true;
            int index = input.Length / 2;
            string charsLeft = input.Substring(index, 1);
            string charRight = input.Substring(index, 2);
            if (charsLeft == charRight)
            {
                Console.WriteLine(isFound); ;
            }
            else if (charRight != charsLeft)
            {
                Console.WriteLine(!isFound);
            }           
        }
        static void PalindromeIntegersOdd(string input)
        {
            bool isFound = true;
            
                int index = input.Length / 2;
                string charsLeft = input.Substring(index, 2);
                string charRight = input.Substring(index, 1);
                if (charsLeft == charRight)
                {
                    Console.WriteLine(isFound);
                }
                else if (charRight != charsLeft)
                {
                    Console.WriteLine(!isFound);
                }
        }
    }
}
