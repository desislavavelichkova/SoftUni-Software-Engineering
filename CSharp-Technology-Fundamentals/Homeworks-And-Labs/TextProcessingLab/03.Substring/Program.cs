using System;
using System.Linq;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(word.ToLower());

            while (index != -1)
            {
                text = text.Remove(index, word.Length);

                index = text.IndexOf(word.ToLower());
            }
            Console.WriteLine(text);
        }
    }
}
