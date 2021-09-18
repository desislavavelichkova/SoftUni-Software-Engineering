using System;

namespace _01.EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Complete")
            {
                string[] cmndArgs = input.Split(" ");
                string firstCommand = cmndArgs[0];
                
                if (firstCommand == "Make")
                {
                    string secondCommand = cmndArgs[1];
                    if (secondCommand == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else if (secondCommand == "Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (firstCommand == "GetDomain")
                {
                    int count = int.Parse(cmndArgs[1]);
                    string domain = "";
                    for (int i = email.Length - 3; i < email.Length; i++)
                    {
                        domain += email[i];
                    }
                    Console.WriteLine(domain);
                }
                else if (firstCommand == "GetUsername")
                {
                    if (!email.Contains("@"))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        int index = email.IndexOf("@");
                        string userName = email.Substring(0, index);
                        Console.WriteLine(userName);
                    }
                }
                else if (firstCommand == "Replace")
                {
                    string charSymbol = cmndArgs[1];
                    email = email.Replace(charSymbol, "-");
                    Console.WriteLine(email);
                }
                else if (firstCommand == "Encrypt")
                {
                    for (int i = 0; i < email.Length; i++)
                    {                        
                       Console.Write($"{(int)email[i]} ");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
