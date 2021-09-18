using System;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();

            string firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());
            int temp = 0;

            if (firstNumber == "" || secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var ch in firstNumber.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * secondNumber + temp;

                int restDigit = result % 10;
                temp = result / 10;

                int total = restDigit;

                sb.Insert(0, restDigit);
            }
            if (temp > 0)
            {
                sb.Insert(0, temp);
            }
           
            Console.WriteLine(sb.ToString());
        }
    }
}
