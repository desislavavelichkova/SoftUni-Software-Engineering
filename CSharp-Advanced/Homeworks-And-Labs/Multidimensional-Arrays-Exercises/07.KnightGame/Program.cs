using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 3)
            {
                Console.WriteLine("0");

            }
            string[,] matrix = new string[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col].ToString();
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == "0")
                    {
                        continue;
                    }
                    else if (matrix[row,col] == "K")
                    {
                        
                    }


                }
            }

        }
    }
}
