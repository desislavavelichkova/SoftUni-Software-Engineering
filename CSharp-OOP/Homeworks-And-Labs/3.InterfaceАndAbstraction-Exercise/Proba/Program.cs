using System;

namespace Proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
