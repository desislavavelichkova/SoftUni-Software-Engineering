using System;
using System.Linq;

namespace _3.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] evenArr = new string[n];
            string[] oddArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] arraw = Console.ReadLine()
                                .Split(" ")                                
                                .ToArray();
                string indexZeroElement = arraw[0];
                string indexFirstElement = arraw[1];
                
                if (i % 2 == 1)
                {
                    oddArr[i] = indexZeroElement;
                    evenArr[i] = indexFirstElement;

                }
                else if (i % 2 == 0)
                {
                    evenArr[i] = indexZeroElement;
                    oddArr[i] = indexFirstElement;
                }
                
            }
            Console.WriteLine(string.Join(" ", evenArr));
            Console.WriteLine(string.Join(" ", oddArr));

        }
    }
}
