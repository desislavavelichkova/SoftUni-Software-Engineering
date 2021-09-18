using System;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int niceKidsBecamePresents = 0;

            int countOfGoodKids = 0;

            string[,] matrix = new string[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] colElements = Console.ReadLine().Split(" ");

                for (int col = 0; col < colElements.Length; col++)
                {
                    matrix[row, col] = colElements[col].ToString();
                    if (matrix[row, col] == "V")
                    {
                        countOfGoodKids++;
                    }

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
            string input = Console.ReadLine();

            while (input != "Christmas morning")
            {
                matrix[startRow, startCol] = "-";

                if (input == "up")
                {
                    startRow -= 1;

                    if (matrix[startRow, startCol] == "X")
                    {
                        matrix[startRow, startCol] = "S";
                    }

                    else if (matrix[startRow, startCol] == "V")
                    {
                        matrix[startRow, startCol] = "S";
                        presents--;
                        niceKidsBecamePresents++;
                    }

                    if (matrix[startRow, startCol] == "C")
                    {
                        matrix[startRow, startCol] = "S";

                        if (matrix[startRow - 1, startCol] == "V")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow - 1, startCol] == "X")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol - 1] == "V")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol - 1] == "X")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow + 1, startCol] == "V")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow + 1, startCol] == "X")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol + 1] == "V")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol + 1] == "X")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                    }

                }
                else if (input == "down")
                {
                    startRow += 1;

                    if (matrix[startRow, startCol] == "X")
                    {
                        matrix[startRow, startCol] = "S";
                    }

                    else if (matrix[startRow, startCol] == "V")
                    {
                        matrix[startRow, startCol] = "S";
                        presents--;
                        niceKidsBecamePresents++;
                    }

                    if (matrix[startRow, startCol] == "C")
                    {
                        matrix[startRow, startCol] = "S";

                        if (matrix[startRow - 1, startCol] == "V")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow - 1, startCol] == "X")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol - 1] == "V")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol - 1] == "X")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow + 1, startCol] == "V")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow + 1, startCol] == "X")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol + 1] == "V")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol + 1] == "X")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }

                    }
                }

                else if (input == "left")
                {
                    startCol -= 1;
                    if (matrix[startRow, startCol] == "X")
                    {
                        matrix[startRow, startCol] = "S";
                    }

                    else if (matrix[startRow, startCol] == "V")
                    {
                        matrix[startRow, startCol] = "S";
                        presents--;
                        niceKidsBecamePresents++;
                    }

                    if (matrix[startRow, startCol] == "C")
                    {
                        matrix[startRow, startCol] = "S";

                        if (matrix[startRow - 1, startCol] == "V")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow - 1, startCol] == "X")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol - 1] == "V")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol - 1] == "X")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow + 1, startCol] == "V")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow + 1, startCol] == "X")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol + 1] == "V")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol + 1] == "X")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                else if (input == "right")
                {
                    startCol += 1;
                    if (matrix[startRow, startCol] == "X")
                    {
                        matrix[startRow, startCol] = "S";
                    }

                    else if (matrix[startRow, startCol] == "V")
                    {
                        matrix[startRow, startCol] = "S";
                        presents--;
                        niceKidsBecamePresents++;
                    }

                    if (matrix[startRow, startCol] == "C")
                    {
                        matrix[startRow, startCol] = "S";

                        if (matrix[startRow - 1, startCol] == "V")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow - 1, startCol] == "X")
                        {
                            matrix[startRow - 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol - 1] == "V")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol - 1] == "X")
                        {
                            matrix[startRow, startCol - 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow + 1, startCol] == "V")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow + 1, startCol] == "X")
                        {
                            matrix[startRow + 1, startCol] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        if (matrix[startRow, startCol + 1] == "V")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            niceKidsBecamePresents++;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                        else if (matrix[startRow, startCol + 1] == "X")
                        {
                            matrix[startRow, startCol + 1] = "-";
                            presents--;
                            if (presents == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                if (presents == 0)
                {
                    break;
                }

                input = Console.ReadLine();                
            }

            if (presents == 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            if (niceKidsBecamePresents == countOfGoodKids)
            {
                Console.WriteLine($"Good job, Santa! {countOfGoodKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {countOfGoodKids - niceKidsBecamePresents} nice kid/s.");

            }

        }
    }
}
