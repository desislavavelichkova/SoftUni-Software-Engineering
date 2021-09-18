using System;
using System.Linq;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            string commonElement = "";

            for (int i = 0; i <= secondArr.Length - 1; i++)
            {
                for (int j = 0; j <= firstArr.Length - 1 ; j++)
                {
                    if (secondArr[i] == firstArr[j])
                    {
                        commonElement = secondArr[i];
                        Console.Write(commonElement + " ");
                    }
                    
                }
            }
        }
    }
}
