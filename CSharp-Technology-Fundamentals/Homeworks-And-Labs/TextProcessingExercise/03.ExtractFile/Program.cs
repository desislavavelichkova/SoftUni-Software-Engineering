using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine().Split("\\");

            string[] lastFile = filePath[filePath.Length - 1].Split(".");

            Console.WriteLine($"File name: {string.Join(" ",lastFile[0])}");
            Console.WriteLine($"File extension: {string.Join(" ", lastFile[1])}");
        }
    }
}
