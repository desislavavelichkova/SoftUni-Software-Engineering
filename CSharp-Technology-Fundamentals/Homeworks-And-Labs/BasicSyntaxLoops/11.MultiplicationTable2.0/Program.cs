using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine($"{theInteger} X {n} = {theInteger * n}");
            }
            else
            {
                for (int i = n; i <= 10; i++)
                {
                    Console.WriteLine($"{theInteger} X {i} = {theInteger * i}");
                }
            }
        }
    }
}
