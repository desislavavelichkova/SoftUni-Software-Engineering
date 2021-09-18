using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElements = Console.ReadLine();                                    
                                    
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isFound = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentChar = matrix[row, col];
                    if (currentChar == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        break;
                    }
                    else
                    {
                        isFound = false;
                    }
                    
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
