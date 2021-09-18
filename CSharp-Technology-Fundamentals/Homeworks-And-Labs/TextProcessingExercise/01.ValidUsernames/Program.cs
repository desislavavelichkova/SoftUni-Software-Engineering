using System;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] users = Console.ReadLine()
                            .Split(", ");
            
            for (int i = 0; i < users.Length; i++)
            {
                string currentUser = users[i];

                if (currentUser.Length > 3 && currentUser.Length < 16
                && currentUser.All(c => char.IsLetterOrDigit(c))
                || currentUser.Contains('-') || currentUser.Contains('_'))
                {
                    Console.WriteLine(currentUser);
                }
            }
        }
    }
}
