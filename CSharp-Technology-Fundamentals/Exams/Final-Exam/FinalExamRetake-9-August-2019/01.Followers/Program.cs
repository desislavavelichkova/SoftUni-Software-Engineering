using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Followers
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> followersAndLikes = new Dictionary<string, int>();            
            
            string input = Console.ReadLine();

            while (input != "Log out")
            {
                string[] cmndARgs = input.Split(":");

                string userName = cmndARgs[1];

                if (cmndARgs[0] == "New follower")
                {
                    if (!followersAndLikes.ContainsKey(userName))
                    {
                        followersAndLikes.Add(userName, 0);
                    }
                }
                else if (cmndARgs[0] == "Like")
                {
                    int likeCount = int.Parse(cmndARgs[2]);

                    if (!followersAndLikes.ContainsKey(userName))
                    {                        
                        followersAndLikes.Add(userName, likeCount);
                    }
                    else
                    {
                        followersAndLikes[userName] += likeCount;
                    }
                }
                else if (cmndARgs[0] == "Comment")
                {
                    if (!followersAndLikes.ContainsKey(userName))
                    {                        
                        followersAndLikes.Add(userName, 1);
                    }
                    else
                    {
                        followersAndLikes[userName]++;
                    }
                }
                else if (cmndARgs[0] == "Blocked")
                {                    
                    followersAndLikes.Remove(userName);
                    Console.WriteLine($"{userName} doesn't exist.");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{followersAndLikes.Count} followers");

            foreach (var username in followersAndLikes.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{username.Key}: {username.Value}");
            }
        }
    }    
}
