using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameOfWeapon = Console.ReadLine()
                                    .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            string input = Console.ReadLine();
            List<string> evenElements = new List<string>();
            List<string> oddElements = new List<string>();

            while (input != "Done")
            {
                string[] cmndAgms = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                string firstCommand = cmndAgms[0];
                string secondCommand = cmndAgms[1];

                if ( firstCommand == "Move")
                {
                    if (secondCommand == "Left")
                    {
                        int index = int.Parse(cmndAgms[2]);

                        if (index > 0 && index <= nameOfWeapon.Count - 1)
                        {
                            string oldIndex = nameOfWeapon[index - 1];
                            nameOfWeapon[index - 1] = nameOfWeapon[index];
                            nameOfWeapon[index] = oldIndex;
                        }
                    }
                    else if (secondCommand == "Right")
                    {
                        int index = int.Parse(cmndAgms[2]);

                        if (index >= 0 && index < nameOfWeapon.Count - 1)
                        {
                            string oldIndex = nameOfWeapon[index + 1];
                            nameOfWeapon[index + 1] = nameOfWeapon[index];
                            nameOfWeapon[index] = oldIndex;
                        }
                    }

                }

                else if (firstCommand == "Check")
                {
                    if (secondCommand == "Even")
                    {
                        for (int i = 0; i < nameOfWeapon.Count; i++)
                        {
                            if (i % 2 == 0)
                            {
                                evenElements.Add(nameOfWeapon[i]);                                
                            }
                        }
                        Console.WriteLine(string.Join(" ", evenElements));
                    }

                    else if (secondCommand == "Odd")
                    {
                        for (int i = 0; i < nameOfWeapon.Count; i++)
                        {
                            if (i % 2 != 0)
                            {
                                oddElements.Add(nameOfWeapon[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", oddElements));
                    }
                }

                input = Console.ReadLine();
            }
            
            Console.WriteLine($"You crafted {string.Join("",nameOfWeapon)}!");
        }
    }
}
