using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+(359)(-| )[2]\2([0-9]{3})\2([0-9]{4})\b";
            string phoneNumbers = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(phoneNumbers);

            var matchedPhones = matches
                                 .Cast<Match>()
                                 .Select(a => a.Value.Trim())
                                 .ToArray();
            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
