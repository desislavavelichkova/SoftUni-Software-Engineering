using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> userInformation = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
                string userName = input[1];
                

                if (command == "register")
                {
                    string licensePlateNumber = input[2];

                    if (userInformation.ContainsKey(userName) == false)
                    {
                        userInformation.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    if (userInformation.ContainsKey(userName) == false)
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        userInformation.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }                
            }
            foreach (var user in userInformation)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
            
        }
    }
}
