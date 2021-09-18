using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SquarewithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimention = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            int[,] matrix = new int[matrixDimention[0], matrixDimention[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }

            }

            int maxSum = 0;        
            int maxCol = 0;
            int maxRow = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    sum = matrix[row, col] + matrix[row + 1, col]
                         + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            
            for (int row = maxRow; row < maxRow + 2; row++)
            {
                List<int> numbers = new List<int>();

                for (int col = maxCol; col < maxCol + 2; col++)
                {
                    numbers.Add(matrix[row, col]);
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
            Console.WriteLine(maxSum);
        }
    }
}
