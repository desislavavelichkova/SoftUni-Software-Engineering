using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];                    
                }               
            }
            int firstSum = 0;
            int secondSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row ==  col)
                    {
                        firstSum += matrix[row, col];
                    }
                    if (row + col == matrix.GetLength(0) - 1)
                    {
                        secondSum += matrix[row, col];

                    }
                }
            }
            Console.WriteLine(Math.Abs(secondSum - firstSum));
            
        }
    }
}
