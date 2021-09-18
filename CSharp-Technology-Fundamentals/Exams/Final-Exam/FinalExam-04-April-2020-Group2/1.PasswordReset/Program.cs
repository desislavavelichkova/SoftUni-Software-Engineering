using System;
using System.Linq;

namespace _1.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] cmndArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmndArg[0];

                var newPass = "";
                if (command == "TakeOdd")
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                           newPass += password[i];
                        }
                    }
                    password = newPass;
                    Console.WriteLine(password);                
                }
                else if(command == "Cut")
                {
                    int index = int.Parse(cmndArg[1]);
                    int length = int.Parse(cmndArg[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string substring = cmndArg[1];
                    string substitute = cmndArg[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
        
    }
}
