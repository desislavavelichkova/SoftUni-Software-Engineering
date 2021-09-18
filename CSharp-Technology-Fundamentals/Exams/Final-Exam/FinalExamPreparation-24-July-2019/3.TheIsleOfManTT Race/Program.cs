using System;
using System.Text.RegularExpressions;

namespace _3.TheIsleOfManTT_Race
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            while (true)
            {                
                string pattern = @"(#|\$|%|\*|&)([A-Za-z]+)\1=([0-9]+)!!(\w+)";
                Match match = Regex.Match(input, pattern);
                int key = int.Parse(match.Groups[3].Value);
                string geohashcode = match.Groups[4].ToString();





                input = Console.ReadLine();

            }
        }
    }
}
