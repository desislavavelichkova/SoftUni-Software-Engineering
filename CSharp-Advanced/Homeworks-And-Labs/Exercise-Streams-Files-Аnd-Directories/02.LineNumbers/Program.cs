using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("text.txt");
            using (reader)
            {
                int counter = 0;

                string line = reader.ReadLine();

                using (var writer = new StreamWriter("output.txt"))
                {
                    
                    while (line != null)
                    {
                        string[] lineArray = line.Split(" ");
                        int punctuationCount = 0;
                        int sumWordLenght = 0;
                        for (int i = 0; i < lineArray.Length; i++)
                        {
                            sumWordLenght += lineArray[i].Length;
                            string currentWord = lineArray[i];

                            for (int j = 0; j < currentWord.Length; j++)
                            {
                                if (       currentWord[j] == '-'
                                        || currentWord[j] == '.'
                                        || currentWord[j] == ','
                                        || currentWord[j] == '!'
                                        || currentWord[j] == '?'
                                        || currentWord[j] == ';'
                                        || currentWord[j] == '\''
                                        || currentWord[j] == '"')
                                { 
                                    punctuationCount++;
                                    
                                }
                            }
                        }
                        counter++;
                        writer.WriteLine($"Line {counter}: {line}({sumWordLenght - punctuationCount})({punctuationCount})");

                        line = reader.ReadLine();
                    }
                    
                }
            }
        }
    }
}
