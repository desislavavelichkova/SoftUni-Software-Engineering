﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            string[] command = Console.ReadLine()
                                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            
            while (command[0].ToUpper() != "END")
            {
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "REMOVE":
                        numbers.Remove(int.Parse(command[1]));
                        break;
                    case "REMOVEAT":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(command[2]),int.Parse(command[1]));
                        break;
                }
                command = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            
                Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
