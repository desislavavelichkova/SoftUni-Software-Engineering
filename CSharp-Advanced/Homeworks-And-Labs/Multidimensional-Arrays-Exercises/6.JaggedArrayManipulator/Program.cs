using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rowSize][];

            for (int row = 0; row < rowSize; row++)
            {
                double[] col = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(double.Parse)
                            .ToArray();
                matrix[row] = col;
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmnArds = input.Split(" ");
                string command = cmnArds[0];
                int rowIndex = int.Parse(cmnArds[1]);
                int colIndex = int.Parse(cmnArds[2]);
                double value = int.Parse(cmnArds[3]);
                bool isValidRow = rowIndex >= 0 && rowIndex < rowSize && colIndex >= 0 && colIndex < matrix[rowIndex].Length;

                if (command == "Add")
                {
                    if (!isValidRow)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    for (int row = 0; row < rowSize; row++)
                    {
                        if (colIndex >= 0 && colIndex < matrix[row].Length)
                        {
                            for (int col = 0; col < matrix[row].Length; col++)
                            {
                                if (row == rowIndex && col == colIndex)
                                {
                                    matrix[row][col] += value;
                                    break;
                                }
                            }
                        }
                    }
                }
                else if (command == "Subtract")
                {
                    if (!isValidRow)
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    for (int row = 0; row < rowSize; row++)
                    {
                        if (colIndex >= 0 && colIndex < matrix[row].Length)
                        {
                            for (int col = 0; col < matrix[row].Length; col++)
                            {
                                if (row == rowIndex && col == colIndex)
                                {
                                    matrix[row][col] -= value;
                                    break;
                                }
                            }
                        }                        
                    }
                }
                input = Console.ReadLine();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
