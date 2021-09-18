using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            string[] inputCoordinats = Console.ReadLine().Split(" ");
            int aliveCells = 0;
            int sumOfAliveCells = 0;
            for (int i = 0; i < inputCoordinats.Length; i++)
            {
                int[] bombCoordinates = inputCoordinats[i].Split(",").Select(int.Parse).ToArray();
                int bombRow = bombCoordinates[0];
                int bombCol = bombCoordinates[1];
                int bombValue = matrix[bombRow, bombCol];
                if (matrix[bombRow, bombCol] <= 0)
                {
                    continue;
                }
                
                for (int r = bombRow - 1; r <= bombRow + 1; r++)
                {
                    for (int c = bombCol - 1; c <= bombCol + 1; c++)
                    {

                        if (r >= 0 && r < n && c >= 0 && c < n && matrix[r,c] > 0)
                        {
                         matrix[r,c] -= bombValue;
                        }
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sumOfAliveCells += matrix[row, col];
                    }
                }
            }
                       
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
