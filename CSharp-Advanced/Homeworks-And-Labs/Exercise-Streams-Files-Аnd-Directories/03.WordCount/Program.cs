using System;
using System.Collections.Generic;
using System.IO;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("words.txt");

            using (reader)
            {
                string word = reader.ReadLine();
                                
                while (word != null)
                {
                    var textReader = new StreamReader("text.txt");

                    using (textReader)
                    {
                        string line = textReader.ReadLine();

                        using (var writer = new StreamWriter("actualResult.txt"))
                        {
                            int wordCount = 0;
                     
                            while (line != null)
                            {
                                string[] lineArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                                
                                for (int i = 0; i < lineArray.Length; i++)
                                {
                                    if (lineArray[i].ToLower().Contains(word))
                                    {
                                        wordCount++;
                                    }
                                }

                                line = textReader.ReadLine();
                            }
                            string info = $"{word}" + " - " + $"{wordCount}";
                            List<string> infoWords = new List<string>();
                            infoWords.Add(info);
                                                     

                        }                        
                    }
                    //writer.WriteLine(info.ToString());
                    word = reader.ReadLine();
                }
            }
        }
    }
}
