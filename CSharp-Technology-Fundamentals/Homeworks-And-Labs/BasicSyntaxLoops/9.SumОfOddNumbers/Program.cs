using System;

namespace _9.SumОfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 0;
            var sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i %2 != 0 )
                {
                    counter ++;
                    if (counter <= n)
                    {
                        Console.WriteLine(i);
                        sum += i;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Sum: {sum}");   
        }
    }
}
