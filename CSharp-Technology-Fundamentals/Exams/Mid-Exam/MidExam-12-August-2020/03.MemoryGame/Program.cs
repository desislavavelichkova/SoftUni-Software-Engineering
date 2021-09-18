using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)  
                                    
                                    .ToList();

            string input = Console.ReadLine();
            int moves = 0;
            

            while (input != "end")
            {
                string[] cmndArg = input
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                int index1 = int.Parse(cmndArg[0]);
                int index2 = int.Parse(cmndArg[1]);
                
                int numberOfElements = elements.Count;

                if (numberOfElements == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    Environment.Exit(0);
                }

                moves++;
                if (index1 < 0 || index2 < 0 || index1 >= elements.Count || index2 >= elements.Count)
                {                   

                    int newIndex = elements.Count / 2;
                    //elements.Insert(newIndex, moves);
                    //elements.Insert(newIndex + 1, moves);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");


                    input = Console.ReadLine();
                    continue;
                }

                else if (elements[index1] == elements[index2])
                {
                    
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                    if (index1 < index2)
                    {
                        elements.RemoveAt(index2);                        
                        elements.RemoveAt(index1);
                        
                    }
                    else if (index1 > index2)
                    {
                        elements.RemoveAt(index1);
                        elements.RemoveAt(index2);
                    }
                    
                }

                else if (elements[index1] != elements[index2])
                {
                    Console.WriteLine("Try again!");
                }

                

                input = Console.ReadLine();
            }
           
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
