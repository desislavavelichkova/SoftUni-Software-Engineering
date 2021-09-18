using System;

namespace _02.Selling
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
                    if (matrix[row, col] == "S")
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            int money = 0;
            string startIndex = matrix[startRow, startCol];


            while (money < 50)
            {
                startIndex = matrix[startRow, startCol];
                                
                if (command == "up")
                {
                    if (startRow - 1 < 0 )
                    {
                        matrix[startRow, startCol] = "-";
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        break;
                    }

                    string nextIndex = matrix[startRow - 1, startCol];

                    if (nextIndex == "O")
                    {
                        for (int row = startRow - 1; row <= startRow - 1; row++)
                        {
                            for (int col = startCol; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow - 1, startCol] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[row, col] = "S";
                                    startRow = row;
                                    startCol = col;
                                }

                            }
                        }

                        if (startRow - 1 < 0)
                        {
                            matrix[startRow, startCol] = "-";
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            break;
                        }
                        for (int row = startRow; row < n; row++)
                        {
                            for (int col = 0; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow - 1, startCol] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[row, col] = "S";
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }
                    }
                    else if (nextIndex == "-")
                    {
                        matrix[startRow, startCol] = "-";
                        matrix[startRow - 1, startCol] = "S";
                        startRow = startRow - 1;                        
                    }
                    else
                    {
                        money += int.Parse(nextIndex);
                        matrix[startRow, startCol] = "-";
                        matrix[startRow - 1, startCol] = "S";
                        startRow = startRow - 1;
                    }
                }

                else if (command == "down")
                {
                    if (startRow + 1 == n)
                    {
                        matrix[startRow, startCol] = "-";
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        break;
                    }

                    string nextIndex = matrix[startRow + 1, startCol];

                    if (nextIndex == "O")
                    {
                        for (int row = startRow + 1; row <= startRow + 1; row++)
                        {
                            for (int col = startCol; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow + 1, startCol] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[row, col] = "S";
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }
                        if (startRow + 1 == n)
                        {
                            matrix[startRow, startCol] = "-";
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            break;
                        }

                        for (int row = startRow + 2; row < n; row++)
                        {
                            for (int col = 0; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow + 1, startCol] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[row, col] = "S";
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }
                    }
                    else if (nextIndex == "-")
                    {
                        matrix[startRow, startCol] = "-";
                        matrix[startRow + 1, startCol] = "S";
                        startRow = startRow + 1;
                    }
                    else
                    {
                        money += int.Parse(nextIndex);
                        matrix[startRow, startCol] = "-";
                        matrix[startRow + 1, startCol] = "S";
                        startRow = startRow + 1;
                    }
                }
                else if (command == "left")
                {
                    if (startCol - 1 < 0)
                    {
                        matrix[startRow, startCol] = "-";
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        break;
                    }

                    string nextIndex = matrix[startRow, startCol - 1];

                    if (nextIndex == "O")
                    {
                        for (int row = startRow; row <= startRow; row++)
                        {
                            for (int col = startCol + 1; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow, startCol - 1] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[startRow, startCol] = "S";
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }
                        if (startCol - 1 < 0)
                        {
                            matrix[startRow, startCol] = "-";
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            break;
                        }

                        for (int row = startRow + 1; row < n; row++)
                        {
                            for (int col = 0; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow, startCol - 1] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[row, col] = "S";
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }
                    }
                    else if (nextIndex == "-")
                    {
                        matrix[startRow, startCol] = "-";
                        matrix[startRow, startCol - 1] = "S";
                        startCol = startCol - 1;
                    }
                    else
                    {
                        money += int.Parse(nextIndex);
                        matrix[startRow, startCol] = "-";
                        matrix[startRow, startCol - 1] = "S";
                        startCol = startCol - 1;
                    }
                }
                else if (command == "right")
                {
                    if (startCol + 1 == n)
                    {
                        matrix[startRow, startCol] = "-";
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        break;
                    }
                    string nextIndex = matrix[startRow, startCol + 1];

                    if (nextIndex == "O")
                    {
                        for (int row = startRow; row <= startRow; row++)
                        {
                            for (int col = startCol + 2; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow, startCol + 1] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[row, col] = "S";
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }                        

                        if (startCol + 1 == n)
                        {
                            matrix[startRow, startCol] = "-";
                            Console.WriteLine("Bad news, you are out of the bakery.");
                            break;
                        }
                        for (int row = startRow + 1; row < n; row++)
                        {
                            for (int col = 0; col < n; col++)
                            {
                                if (matrix[row, col] == "O")
                                {
                                    matrix[startRow, startCol + 1] = "-";
                                    matrix[startRow, startCol] = "-";
                                    matrix[row, col] = "S";
                                    startRow = row;
                                    startCol = col;
                                }
                            }
                        }
                    }
                    else if (nextIndex == "-")
                    {
                        matrix[startRow, startCol] = "-";
                        matrix[startRow, startCol + 1] = "S";
                        startCol = startCol + 1;
                    }
                    else
                    {
                        money += int.Parse(nextIndex);
                        matrix[startRow, startCol] = "-";
                        matrix[startRow, startCol + 1] = "S";
                        startCol += 1;
                    }
                }

                command = Console.ReadLine();
            }
            if (money >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            
            Console.WriteLine($"Money: {money}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
