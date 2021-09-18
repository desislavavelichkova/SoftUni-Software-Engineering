using System;

namespace _07.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            LineOfNumbers(number);
        }

        static void LineOfNumbers (int number)
        {
            for (int i = 0; i < number; i++)
            {                
                for (int j = 1; j < number; j++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine(number + " ");
            }
        }
        
    }
}
