using System;
using System.Collections.Generic;
using System.IO;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("Text.txt");

            using (reader)
            {
                int counter = 0;
                string input = reader.ReadLine();
                
                using (var writer = new StreamWriter("Output.txt"))
                {
                    while (input != null)
                    {
                        string[] line = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);                        
                        string reverseString = string.Empty;
                        if (counter % 2 == 0)
                        {
                            for (int i = 0; i < line.Length; i++)
                            {
                                if (line[i].Contains('-'))
                                {
                                    line[i] = line[i].Replace('-', '@');
                                }

                                else if (line[i].Contains('.'))
                                {
                                    line[i] = line[i].Replace('.', '@');
                                }
                                else if (line[i].Contains(','))
                                {
                                    line[i] = line[i].Replace(',', '@');
                                }
                                else if (line[i].Contains('!'))
                                {
                                    line[i] = line[i].Replace('!', '@');
                                }
                                else if (line[i].Contains('?'))
                                {
                                    line[i] = line[i].Replace('?', '@');
                                }
                            }
                                foreach (var c in line)
                                {
                                    reverseString = c + " " + reverseString;
                                }

                            
                            writer.WriteLine(reverseString);
                        }
                        counter++;
                        input = reader.ReadLine();
                    }
                    
                }
            }
        }
    }
}
