using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] cmndArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmndArgs[0].ToLower();
                int row = int.Parse(cmndArgs[1]);
                int col = int.Parse(cmndArgs[2]);
                int value = int.Parse(cmndArgs[3]);

                if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine();
                    continue;
                    //input = Console.ReadLine();
                }
                if (command == "add")
                {   
                   matrix[row, col] += value;
                    
                }
                if (command == "subtract")
                {   
                   matrix[row, col] -= value;                    
                }

                input = Console.ReadLine();
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
