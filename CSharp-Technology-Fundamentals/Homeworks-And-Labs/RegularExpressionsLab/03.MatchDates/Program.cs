using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(-|\.|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string input = Console.ReadLine();

            MatchCollection matchedDates = Regex.Matches(input, pattern);           

            foreach (Match match in matchedDates)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
