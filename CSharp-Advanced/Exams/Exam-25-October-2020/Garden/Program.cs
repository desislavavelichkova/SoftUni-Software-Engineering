using System;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = sizeOfMatrix[0];
            int m = sizeOfMatrix[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {              
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string input = Console.ReadLine();

            while (input != "Bloom Bloom Plow")
            {
                int[] magicFlower = input.Split(" ")
                                         .Select(int.Parse)
                                         .ToArray();
                int magicRow = magicFlower[0];
                int magicCol = magicFlower[1];

                bool isValid = magicRow >= 0 && magicRow < n && magicCol >= 0 && magicCol < m;

                if (!isValid)
                {
                    Console.WriteLine("Invalid coordinates.");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {

                    for (int row = magicRow; row <= magicRow; row++)
                    {
                        for (int col = 0; col < m; col++)
                        {
                            matrix[row, col]++;
                        }
                    }
                    for (int row = 0; row < n; row++)
                    {
                        for (int col = magicCol; col <= magicCol; col++)
                        {
                            if (magicRow == row && magicCol == col)
                            {
                                continue;
                            }

                            matrix[row, col]++;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
