using System;
using System.Collections.Generic;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Stack<string> letters = new Stack<string>();

            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            for (int r = 0; r < n; r++)
            {
                string colElements = Console.ReadLine();

                for (int c = 0; c < colElements.Length; c++)
                {
                    matrix[r, c] = colElements[c].ToString();
                }
            }

            int row = 0;
            int col = 0;

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (matrix[r, c] == "P")
                    {
                        row = r;
                        col = c;
                        break;
                    }
                }
            }

            string lastLetter = null;
            int rowWithLetter = 0;
            int colWithLetter = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                matrix[row, col] = "-";

                if (input == "up")
                {
                    if (letters.Count > 0)
                    {
                        if (matrix[rowWithLetter, colWithLetter] != "-")
                        {
                            letters.Pop();
                        }
                        row = row;
                        matrix[row, col] = "P";
                    }
                    else
                    {
                        row = row - 1;

                        if (matrix[row, col] == "-")
                        {
                            matrix[row, col] = "P";
                        }

                        else if (matrix[row, col] != "-")
                        {
                            lastLetter = matrix[row, col];
                            rowWithLetter = row;
                            colWithLetter = col;
                            letters.Push(lastLetter);

                            matrix[row, col] = "P";
                        }
                    }
                }

                else if (input == "down")
                {
                    if (row + 1 == n)
                    {
                        if (letters.Count > 0)
                        {
                            if (matrix[rowWithLetter, colWithLetter] != "-")
                            {
                                letters.Pop();
                            }
                        }

                        row = row;
                        matrix[row, col] = "P";
                    }
                    else
                    {
                        row = row + 1;

                        if (matrix[row, col] == "-")
                        {
                            matrix[row, col] = "P";
                        }

                        else if (matrix[row, col] != "-")
                        {
                            lastLetter = matrix[row, col];
                            rowWithLetter = row;
                            colWithLetter = col;
                            letters.Push(lastLetter);

                            matrix[row, col] = "P";
                        }
                    }
                }

                else if (input == "left")
                {
                    if (col - 1 < 0)
                    {
                        if (letters.Count > 0)
                        {
                            if (matrix[rowWithLetter, colWithLetter] != "-")
                            {
                                letters.Pop();
                            }
                        }
                        col = col;
                        matrix[row, col] = "P";

                    }
                    else
                    {
                        col = col - 1;

                        if (matrix[row, col] == "-")
                        {
                            matrix[row, col] = "P";
                        }
                        else if (matrix[row, col] != "-")
                        {
                            lastLetter = matrix[row, col];
                            rowWithLetter = row;
                            colWithLetter = col;
                            letters.Push(lastLetter);
                            matrix[row, col] = "P";
                        }
                    }
                }

                else if (input == "right")
                {
                    if (col + 1 == n)
                    {
                        if (letters.Count > 0)
                        {
                            if (matrix[rowWithLetter, colWithLetter] != "-")
                            {
                                letters.Pop();
                            }

                        }

                        col = col;
                        matrix[row, col] = "P";
                    }
                    else
                    {
                        col = col + 1;

                        if (matrix[row, col] == "-")
                        {
                            matrix[row, col] = "P";
                        }

                        else if (matrix[row, col] != "-")
                        {
                            lastLetter = matrix[row, col];
                            rowWithLetter = row;
                            colWithLetter = col;
                            letters.Push(lastLetter);

                            matrix[row, col] = "P";
                        }
                    }
                }

            }
        

            Console.WriteLine($"{word}{string.Join("", letters)}");

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
