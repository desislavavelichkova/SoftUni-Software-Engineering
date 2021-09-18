using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

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
                    if (matrix[row, col] == "f")
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }


            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();

               string startIndex = matrix[startRow, startCol];

                if (command == "down")
                {
                    matrix[startRow, startCol] = "-";

                    if (startRow + 1 >= n)
                    {                        
                        if (matrix[0 , startCol] == "-")
                        {
                            matrix[0, startCol] = "f";
                            startRow = 0;                            
                        }
                        else if (matrix[0, startCol] == "B")
                        {                            
                            if (matrix[1, startCol] == "-")
                            {
                                matrix[1, startCol] = "f";
                                startRow = 1;
                                
                            }
                            else if (matrix[1, startCol] == "T")
                            {
                                matrix[0, startCol] = "f";
                                startRow = 0;
                            }
                            else if (matrix[1, startCol] == "F")
                            {
                                matrix[0, startCol] = "-";
                                matrix[1, startCol] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[0, startCol] == "T")
                        {
                            matrix[startRow, startCol] = "f";
                            
                        }
                        else if (matrix[0, startCol] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[0, startCol] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else
                    {
                        if (matrix[startRow + 1, startCol] == "-")
                        {
                            matrix[startRow + 1, startCol] = "f";
                            startRow = startRow + 1;
                        }
                        else if (matrix[startRow + 1, startCol] == "B")
                        {
                            if (matrix[startRow + 2, startCol] == "-")
                            {
                                matrix[startRow + 2, startCol] = "f";
                                startRow = startRow + 2;
                            }
                            else if (matrix[startRow + 2, startCol] == "T")
                            {
                                matrix[startRow + 1, startCol] = "f";
                                startRow = startRow + 1;
                            }
                            else if (matrix[startRow + 2, startCol] == "F")
                            {
                                matrix[startRow + 1, startCol] = "-";
                                matrix[startRow + 2, startCol] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[startRow + 1, startCol] == "T")
                        {                            
                            matrix[startRow, startCol] = "f";
                        }
                        else if (matrix[startRow + 1, startCol] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[startRow + 1, startCol] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }

                else if (command == "up")
                {
                    matrix[startRow, startCol] = "-";

                    if (startRow - 1 < 0)
                    {
                        if (matrix[n - 1, startCol] == "-")
                        {
                            matrix[n - 1, startCol] = "f";
                            startRow = n - 1;
                        }
                        else if (matrix[n - 1, startCol] == "B")
                        {  
                            if (matrix[n - 2, startCol] == "-")
                            {
                                matrix[n - 2, startCol] = "f";
                                startRow = n - 2;
                            }
                            else if (matrix[n - 2, startCol] == "T")
                            {
                                matrix[n - 1, startCol] = "f";
                                startRow = n - 1;
                            }
                            else if (matrix[n - 2, startCol] == "F")
                            {
                                matrix[n - 1, startCol] = "-";
                                matrix[n - 2, startCol] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[n - 1, startCol] == "T")
                        {                          
                            matrix[startRow, startCol] = "f";

                        }
                        else if (matrix[n - 1, startCol] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[n - 1, startCol] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else
                    {
                        if (matrix[startRow - 1, startCol] == "-")
                        {
                            matrix[startRow - 1, startCol] = "f";
                            startRow = startRow - 1;
                        }
                        else if (matrix[startRow - 1, startCol] == "B")
                        {                            
                            if (matrix[startRow - 2, startCol] == "-")
                            {
                                matrix[startRow - 2, startCol] = "f";
                                startRow = startRow - 2;
                            }
                            else if (matrix[startRow - 2, startCol] == "T")
                            {
                                matrix[startRow - 1, startCol] = "f";
                                startRow = startRow - 1;
                            }
                            else if (matrix[startRow - 2, startCol] == "F")
                            {
                                matrix[startRow - 1, startCol] = "-";
                                matrix[startRow - 2, startCol] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[startRow - 1, startCol] == "T")
                        {
                            matrix[startRow, startCol] = "f";
                        }
                        else if (matrix[startRow - 1, startCol] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[startRow - 1, startCol] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }

                if (command == "right")
                {
                    matrix[startRow, startCol] = "-";

                    if (startCol + 1 >= n)
                    {
                        if (matrix[startRow, 0] == "-")
                        {
                            matrix[startRow, 0] = "f";
                            startCol = 0;
                        }
                        else if (matrix[startRow, 0] == "B")
                        {     
                            if (matrix[startRow, 1] == "-")
                            {
                                matrix[startRow, 1] = "f";
                                startCol = 1;

                            }
                            else if (matrix[startRow, 1] == "T")
                            {
                                matrix[startRow, 0] = "f";
                                startCol = 0;
                            }
                            else if (matrix[1, startCol] == "F")
                            {
                                matrix[startRow, 0] = "-";
                                matrix[startRow, 1] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[startRow, 0] == "T")
                        {
                            matrix[startRow, startCol] = "f";

                        }
                        else if (matrix[startRow, 0] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[startRow, 0] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else
                    {
                        if (matrix[startRow, startCol + 1] == "-")
                        {
                            matrix[startRow, startCol + 1] = "f";
                            startCol = startCol + 1;
                        }
                        else if (matrix[startRow, startCol + 1] == "B")
                        {
                            if (matrix[startRow, startCol + 2] == "-")
                            {
                                matrix[startRow , startCol + 2] = "f";
                                startCol = startCol + 2;
                            }
                            else if (matrix[startRow, startCol + 2] == "T")
                            {
                                matrix[startRow, startCol + 1] = "f";
                                startCol = startCol + 1;
                            }
                            else if (matrix[startRow, startCol + 2] == "F")
                            {
                                matrix[startRow, startCol + 1] = "-";
                                matrix[startRow, startCol + 2] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol + 1] == "T")
                        {
                            matrix[startRow, startCol] = "f";
                        }
                        else if (matrix[startRow, startCol + 1] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[startRow, startCol + 1] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }
                else if (command == "left")
                {
                    matrix[startRow, startCol] = "-";

                    if (startCol - 1 < 0)
                    {
                        if (matrix[startRow, n -1] == "-")
                        {
                            matrix[startRow, n - 1] = "f";
                            startCol = n - 1;
                        }
                        else if (matrix[startRow, n - 1] == "B")
                        {
                            if (matrix[startRow, n - 2] == "-")
                            {
                                matrix[startRow, n -2 ] = "f";
                                startCol = n - 2;
                            }
                            else if (matrix[startRow, n - 2] == "T")
                            {
                                matrix[startRow, n - 1] = "f";
                                startCol = n - 1;
                            }
                            else if (matrix[startRow, n -2] == "F")
                            {
                                matrix[startRow, n - 1] = "-";
                                matrix[startRow, n-2] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[startRow, n -1] == "T")
                        {
                            matrix[startRow, startCol] = "f";

                        }
                        else if (matrix[startRow, n -1] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[startRow, n - 1] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                    else
                    {
                        if (matrix[startRow, startCol - 1] == "-")
                        {
                            matrix[startRow, startCol - 1] = "f";
                            startCol = startCol - 1;
                        }
                        else if (matrix[startRow, startCol - 1] == "B")
                        {
                            if (matrix[startRow, startCol - 2] == "-")
                            {
                                matrix[startRow, startCol - 2] = "f";
                                startCol = startCol - 2;
                            }
                            else if (matrix[startRow, startCol - 2] == "T")
                            {
                                matrix[startRow , startCol - 1] = "f";
                                startCol = startCol - 1;
                            }
                            else if (matrix[startRow, startCol - 2] == "F")
                            {
                                matrix[startRow, startCol - 1] = "-";
                                matrix[startRow, startCol - 2] = "f";
                                Console.WriteLine("Player won!");
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol - 1] == "T")
                        {
                            matrix[startRow, startCol] = "f";
                        }
                        else if (matrix[startRow, startCol - 1] == "F")
                        {
                            matrix[startRow, startCol] = "-";
                            matrix[startRow, startCol -1] = "f";
                            Console.WriteLine("Player won!");
                            break;
                        }
                    }
                }
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
