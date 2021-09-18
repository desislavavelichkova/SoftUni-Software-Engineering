using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int n = matrixSize[0];
            int m = matrixSize[1];
            int[,] matrix = new int[n, m];

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

            int maxSum = 0;
            int sum = 0;
            int maxRow = 0;
            int maxCol = 0;
           
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {                
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum =   matrix[row, col] + matrix[row, col +1] + matrix[row, col + 2]
                          + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                          + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRow; row <= maxRow + 2; row++)
            {
                for (int col = maxCol; col <= maxCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
