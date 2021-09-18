using System;

namespace _02.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[Length];

            for (int i = 1; i <= n; i++)
            {
                int[] arr = new int[i];
                arr[0] = 1;
                arr[i] = arr[i-1] + arr[i + 1];
                
                Console.Write(string.Join(" ",arr));
            }
        }
    }
}
