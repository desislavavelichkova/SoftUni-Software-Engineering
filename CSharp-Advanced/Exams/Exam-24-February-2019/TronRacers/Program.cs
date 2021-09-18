using System;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            for (int row = 0; row < n; row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < colElements.Length; col++)
                {
                    matrix[row, col] = colElements[col].ToString();
                }
            }

            int firstRow = 0;
            int firstCol = 0;
            int secondRow = 0;
            int secondCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == "f")
                    {
                        firstRow = row;
                        firstCol = col;
                        break;
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == "s")
                    {
                        secondRow = row;
                        secondCol = col;
                        break;
                    }
                }
            }

            string input = Console.ReadLine();

            while (true)
            {     
                string[] cmndArgs = input.Split(" ");
                string firstCmnd = cmndArgs[0];
                string secondCmnd = cmndArgs[1];

                if (firstCmnd == "up")
                {  
                    if (firstRow - 1 < 0)
                    {
                        firstRow = n - 1;
                    }
                    else
                    {
                        firstRow = firstRow - 1;
                    }
                    if (matrix[firstRow, firstCol] == "s")
                    {
                        matrix[firstRow, firstCol] = "x";                        
                        break;
                    }
                                       
                    else if (matrix[firstRow, firstCol] == "*")
                    {
                        matrix[firstRow, firstCol] = "f";
                    }
                }
                if (secondCmnd == "up")
                {
                    if (secondRow - 1 < 0)
                    {
                        secondRow = n - 1;
                    }
                    else
                    {
                        secondRow = secondRow - 1;
                    }
                    if (matrix[secondRow, secondCol] == "f")
                    {
                        matrix[secondRow, secondCol] = "x";
                        break;
                    }

                    else if (matrix[secondRow, secondCol] == "*" )
                    {
                        matrix[secondRow, secondCol] = "s";
                    }
                }

                if (firstCmnd == "down")
                {
                    if (firstRow + 1 == n)
                    {
                        firstRow = 0;
                    }
                    else
                    {
                        firstRow = firstRow + 1;
                    }
                    if (matrix[firstRow, firstCol] == "s")
                    {
                        matrix[firstRow, firstCol] = "x";                        
                        break;
                    }
                    else if (matrix[firstRow, firstCol] == "*")
                    {
                        matrix[firstRow, firstCol] = "f";
                    }
                }
                if (secondCmnd == "down")
                {
                    if (secondRow + 1 == n)
                    {
                        secondRow = 0;
                    }
                    else
                    {
                        secondRow = secondRow + 1;
                    }
                    if (matrix[secondRow, secondCol] == "f")
                    {
                        matrix[secondRow, secondCol] = "x";
                        break;
                    }
                    else if (matrix[secondRow, secondCol] == "*")
                    {
                        matrix[secondRow, secondCol] = "s";
                    }
                }

                if (firstCmnd == "left")
                {
                  
                    if (firstCol - 1 < 0)
                    {
                        firstCol = n - 1;
                    }
                    else
                    {
                        firstCol = firstCol - 1;
                    }
                    if (matrix[firstRow, firstCol] == "s")
                    {
                        matrix[firstRow, firstCol] = "x";                        
                        break;
                    }                    
                    else if (matrix[firstRow, firstCol] == "*")
                    {
                        matrix[firstRow, firstCol] = "f";
                    }
                }
                if (secondCmnd == "left")
                {

                    if (secondCol - 1 < 0)
                    {
                        secondCol = n - 1;
                    }
                    else
                    {
                        secondCol = secondCol - 1;
                    }
                    if (matrix[secondRow, secondCol] == "f")
                    {
                        matrix[secondRow, secondCol] = "x";
                        break;
                    }
                    else if (matrix[secondRow, secondCol] == "*")
                    {
                        matrix[secondRow, secondCol] = "s";
                    }
                }
                if (firstCmnd == "right")
                {
                    if (firstCol + 1 == n)
                    {
                        firstCol = 0;
                    }
                    else
                    {
                        firstCol = firstCol + 1;
                    }
                    if (matrix[firstRow, firstCol] == "s")
                    {
                        matrix[firstRow, firstCol] = "x";
                        
                        break;
                    }  
                    else if (matrix[firstRow, firstCol] == "*")
                    {
                        matrix[firstRow, firstCol] = "f";
                    }
                }
                if (secondCmnd == "right")
                {
                    if (secondCol + 1 == n)
                    {
                        secondCol = 0;
                    }
                    else
                    {
                        secondCol = secondCol + 1;
                    }
                    if (matrix[secondRow, secondCol] == "f")
                    {
                        matrix[secondRow, secondCol] = "x";

                        break;
                    }
                    else if (matrix[secondRow, secondCol] == "*")
                    {
                        matrix[secondRow, secondCol] = "s";
                    }
                }
                input = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
