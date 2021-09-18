using System;
using System.Linq;

namespace _02.SumMatrixColumns
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
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }

            }


            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumOfCol = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfCol += matrix[row, col];
                    
                }
                Console.WriteLine(sumOfCol);
            }

        }
    }
}
