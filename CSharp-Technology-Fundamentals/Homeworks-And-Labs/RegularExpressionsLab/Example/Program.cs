using System;
using System.Text.RegularExpressions;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<day>(?:[1-3]?[0-9])|(?:3[01]))-(?<month>[A-Z][a-z]{2})-(?<year>[0-9]{4})";
            string text = @"11-Jan-2010";

            Regex regex = new Regex(pattern);
            var match = regex.Match(text);

            Console.WriteLine(regex.IsMatch(text));
            
        }
    }
}
