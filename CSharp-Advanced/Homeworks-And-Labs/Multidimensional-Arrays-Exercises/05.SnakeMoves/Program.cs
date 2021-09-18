using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            string input = Console.ReadLine();
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix.GetLength(1) == input.Length)
                        {

                        }
                        matrix[row, col] = input[col].ToString();
                        Console.Write(matrix[row, col]);    
                    }
                }
                else
                {
                    if (true)
                    {

                    }
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {                       

                        matrix[row, col] = input[col].ToString();
                        Console.Write(matrix[row, col]);                       
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
