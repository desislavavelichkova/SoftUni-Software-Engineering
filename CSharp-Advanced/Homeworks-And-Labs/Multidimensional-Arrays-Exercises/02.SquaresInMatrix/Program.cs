using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            int rowSize = matrixSize[0];
            int colSize = matrixSize[1];

            string[,] matrix = new string[rowSize, colSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            string currentElement = "";
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentElement = matrix[row, col];

                    if (currentElement == matrix[row, col + 1]
                        && currentElement == matrix[row + 1, col]
                        && currentElement == matrix[row + 1, col + 1])
                    {
                        count++;
                    }

                }

            }
            Console.WriteLine(count);
        }
    }
}
