using System;
using System.Linq;

namespace _8.CondenseArrayТoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
            int count = arr.Length;
            int[] sum = new int[arr.Length - 1];
            int sumArr = 0;
            
            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++) 
                {                    
                    sum[i] = arr[i] + arr[i + 1];              
                    arr[i] = sum[i];
                    sumArr = sum[i];
                }
                count--;
            }
            if (count == 1)
            {
                sumArr = arr[0];
            }

            Console.WriteLine(sumArr);
        }
    }
}
