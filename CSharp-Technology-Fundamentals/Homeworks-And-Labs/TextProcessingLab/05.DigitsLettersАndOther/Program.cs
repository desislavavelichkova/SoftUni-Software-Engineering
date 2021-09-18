using System;
using System.Text;
using System.Linq;

namespace _05.DigitsLettersАndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (Char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);
                }
                else
                {
                    other.Append(text[i]);
                }
            }
            
            Console.WriteLine(digits);            
            Console.WriteLine(letters);            
            Console.WriteLine(other);

        }
    }
}
