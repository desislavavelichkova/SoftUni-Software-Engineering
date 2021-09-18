using System;
using System.Text.RegularExpressions;

namespace _2.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(\w+|\W+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|((\W|\w){3})<\1";
            string password = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match matchPassword = Regex.Match(input, pattern);

                if (matchPassword.Success)
                {
                    password = matchPassword.Groups[2].Value 
                             + matchPassword.Groups[3].Value 
                             + matchPassword.Groups[4].Value
                             + matchPassword.Groups[5].Value;
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }     
            }
        }
    }
}
