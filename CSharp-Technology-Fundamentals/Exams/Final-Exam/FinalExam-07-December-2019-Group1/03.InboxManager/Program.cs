using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countUsers = 0;
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (input != "Statistics")
            {
                string[] cmndArgs = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string command = cmndArgs[0];
                string userName = cmndArgs[1];

                if (command == "Add")
                {
                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }
                    else
                    {
                        users.Add(userName, new List<string>());
                        countUsers++;
                    }
                }
                else if (command == "Send")
                {
                    string email = cmndArgs[2];
                    users[userName].Add(email);
                }
                else if (command == "Delete")
                {
                    if (users.ContainsKey(userName))
                    {
                        users.Remove(userName);
                        countUsers--;
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var user in users.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (var email in user.Value)
                {
                    Console.WriteLine($" - {email}");
                }
            }
        }
    }
}
