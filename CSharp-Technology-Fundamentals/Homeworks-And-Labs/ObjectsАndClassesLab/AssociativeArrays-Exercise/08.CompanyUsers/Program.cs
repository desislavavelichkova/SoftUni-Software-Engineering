using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            List<string> companyID = new List<string>();

            Dictionary<string, List<string>> companyInformation = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] cmndArg = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = cmndArg[0];
                string employerID = cmndArg[1];

                if (companyInformation.ContainsKey(companyName) == false)
                {
                    companyInformation.Add(companyName, new List<string> { employerID });
                }
                else if(companyInformation.ContainsKey(companyName) == true && companyInformation[companyName].Contains(employerID) == false)
                { 
                    companyInformation[companyName].Add(employerID);           
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                    
                }

            input = Console.ReadLine();
            }

            foreach (var item in companyInformation.OrderBy(x => x.Key))
            {                             
                Console.WriteLine($"{item.Key}");

                foreach (var ID in item.Value)
                {
                    Console.WriteLine($"-- {ID}");
                }
            }
        }
    }
}
