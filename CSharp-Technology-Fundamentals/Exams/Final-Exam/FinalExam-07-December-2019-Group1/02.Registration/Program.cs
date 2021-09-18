using System;
using System.Text.RegularExpressions;

namespace _02.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countMatchedEmail = 0;

            for (int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();
                string pattern = @"(U\$)([A-Z][a-z]{2,})\1(P@\$)([a-z]{5,}[1-9]+)\3";
                Match matchedEmail = Regex.Match(email, pattern);
                
                if (matchedEmail.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {matchedEmail.Groups[2].Value}, Password: {matchedEmail.Groups[4].Value}");
                    countMatchedEmail++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }         
            }
            Console.WriteLine($"Successful registrations: {countMatchedEmail}");
        }
    }
}
