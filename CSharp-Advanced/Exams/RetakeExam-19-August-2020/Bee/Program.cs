using System;

namespace Bee
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

            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == "B")
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            int flowersCount = 0;
            string startIndex = matrix[startRow, startCol];

            while (command != "End")
            {
                startIndex = matrix[startRow, startCol];

                if (command == "up")
                {
                    if (startRow - 1 < 0)
                    {
                        matrix[startRow, startCol] = ".";
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    string nextIndex = matrix[startRow - 1, startCol];

                    if (nextIndex == "O")
                    {
                        if (startRow - 2 >= 0)
                        {
                            matrix[startRow, startCol] = ".";
                            matrix[startRow - 1, startCol] = ".";

                            if (matrix[startRow - 2, startCol] == "f")
                            {
                                flowersCount++;
                                matrix[startRow - 2, startCol] = "B";
                            }
                            else
                            {
                                matrix[startRow - 2, startCol] = "B";
                            }
                            startRow = startRow - 2;                            
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                        }
                    }
                    else if (nextIndex == ".")
                    {
                        matrix[startRow, startCol] = ".";
                        matrix[startRow - 1, startCol] = "B";
                        startRow = startRow - 1;
                    }
                    else
                    {
                        flowersCount++;
                        matrix[startRow, startCol] = ".";
                        matrix[startRow - 1, startCol] = "B";
                        startRow = startRow - 1;
                    }
                }

                else if (command == "down")
                {
                    if (startRow + 1 >= n)
                    {
                        matrix[startRow, startCol] = ".";
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    string nextIndex = matrix[startRow + 1, startCol];

                    if (nextIndex == "O")
                    {
                        if (startRow + 2 < n)
                        {
                            matrix[startRow, startCol] = ".";
                            matrix[startRow + 1, startCol] = ".";

                            if (matrix[startRow + 2 , startCol] == "f")
                            {
                                flowersCount++;
                                matrix[startRow + 2, startCol] = "B";
                            }
                            else
                            {
                                matrix[startRow + 2, startCol] = "B";
                            }
                            startRow = startRow + 2;                            
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                        }
                    }
                    else if (nextIndex == ".")
                    {
                        matrix[startRow, startCol] = ".";
                        matrix[startRow + 1, startCol] = "B";
                        startRow = startRow + 1;
                    }
                    else
                    {
                        flowersCount++;
                        matrix[startRow, startCol] = ".";
                        matrix[startRow + 1, startCol] = "B";
                        startRow = startRow + 1;
                    }
                }
                else if (command == "left")
                {
                    if (startCol - 1 < 0)
                    {
                        matrix[startRow, startCol] = ".";
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    string nextIndex = matrix[startRow, startCol - 1];

                    if (nextIndex == "O")
                    {
                        if (startCol - 2 >= 0)
                        {
                            matrix[startRow, startCol] = ".";
                            matrix[startRow, startCol - 1] = ".";

                            if (matrix[startRow, startCol - 2] == "f")
                            {
                                flowersCount++;
                                matrix[startRow, startCol - 2] = "B";
                            }
                            else
                            {
                                matrix[startRow, startCol - 2] = "B";
                            }
                            
                            startCol = startCol - 2;
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                        }
                    }
                    else if (nextIndex == ".")
                    {
                        matrix[startRow, startCol] = ".";
                        matrix[startRow, startCol - 1] = "B";
                        startCol = startCol - 1;
                    }
                    else
                    {
                        flowersCount++;
                        matrix[startRow, startCol] = ".";
                        matrix[startRow, startCol - 1] = "B";
                        startCol = startCol - 1;
                    }
                }
                else if (command == "right")
                {
                    if (startCol + 1 >= n)
                    {
                        matrix[startRow, startCol] = ".";
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    string nextIndex = matrix[startRow, startCol + 1];

                    if (nextIndex == "O")
                    {
                        if (startCol + 2 < n)
                        {
                            matrix[startRow, startCol] = ".";
                            matrix[startRow, startCol + 1] = ".";

                            if (matrix[startRow, startCol + 2] == "f")
                            {
                                flowersCount++;
                                matrix[startRow, startCol + 2] = "B";
                            }
                            else
                            {
                                matrix[startRow, startCol + 2] = "B";
                            }

                            startCol = startCol + 2;
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                        }
                    }
                    else if (nextIndex == ".")
                    {
                        matrix[startRow, startCol] = ".";
                        matrix[startRow, startCol + 1] = "B";
                        startCol = startCol + 1;
                    }
                    else
                    {
                        flowersCount++;
                        matrix[startRow, startCol] = ".";
                        matrix[startRow, startCol + 1] = "B";
                        startCol += 1;
                    }
                }

                    command = Console.ReadLine();
            }
            if (flowersCount < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flowersCount} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersCount} flowers!");
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
