using System;
using System.Linq;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(text, count);
        }
        static void RepeatString(string result, int repeatNum)
        {
            for (int i = 0; i < repeatNum; i++)
            {
                Console.Write(result);
            }
        }
    }
}
