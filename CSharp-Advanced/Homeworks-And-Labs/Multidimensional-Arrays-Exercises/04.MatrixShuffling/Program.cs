using System;
using System.Linq;

namespace _04.MatrixShuffling
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

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine()
                                        .Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] cmndArgs = input.Split(" ");
                if (cmndArgs.Length < 5 || cmndArgs.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                string command = cmndArgs[0];
                int firstRow = int.Parse(cmndArgs[1]);
                int firstCol = int.Parse(cmndArgs[2]);
                int secondRow = int.Parse(cmndArgs[3]);
                int secondCol = int.Parse(cmndArgs[4]);                
               
                if (command == "swap")
                {
                    if (firstRow >= 0 && firstRow < matrix.GetLength(0)
                        && firstCol >= 0 && firstCol < matrix.GetLength(1)
                        && secondRow >= 0 && secondRow < matrix.GetLength(0)
                        && secondCol >= 0 && secondCol < matrix.GetLength(1))
                    {
                        string firstPosition = matrix[firstRow, firstCol];
                        string secondPosition = matrix[secondRow, secondCol];

                        matrix[firstRow, firstCol] = secondPosition;
                        matrix[secondRow, secondCol] = firstPosition;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (firstRow < 0 || firstRow >= matrix.GetLength(0)
                        || firstCol < 0 || firstCol >= matrix.GetLength(1)
                        || secondRow < 0 || secondRow >= matrix.GetLength(0)
                        || secondCol < 0 || secondCol >= matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        input = Console.ReadLine();
                        continue;
                    }
                   
                }                
                else
                {
                    Console.WriteLine("Invalid input!");                    
                    input = Console.ReadLine();
                    continue;
                }
                
                input = Console.ReadLine();
            }

        }
    }
}
