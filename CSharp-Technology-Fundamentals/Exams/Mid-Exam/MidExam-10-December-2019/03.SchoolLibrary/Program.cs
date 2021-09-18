using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> books = Console.ReadLine()
                .Split("&", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            bool isFound = true;
            int foundIndex = 0;

            while (input != "Done")
            {
                string[] cmndArgs = input
                                    .Split(" | ").ToArray();

                string command = cmndArgs[0];

                if (cmndArgs[0] == "Add Book")
                {
                    string bookName = cmndArgs[1];
                    if (!books.Contains(bookName))
                    {
                        books.Insert(0, bookName);
                    }
                }
                else if (cmndArgs[0] == "Take Book")
                {
                    string bookName = cmndArgs[1];

                    if (books.Contains(bookName))
                    {
                        books.Remove(bookName);
                    }
                }

                else if (cmndArgs[0] == "Swap Books")
                {
                    string bookName = cmndArgs[1];
                    string bookName2 = cmndArgs[2];

                    if (books.Contains(bookName) && books.Contains(bookName2))
                    {
                        string oldBook = bookName;
                        string oldbook2 = bookName2;
                        int index = books.FindIndex(x => x == bookName);
                        int index2 = books.FindIndex(x => x == bookName2);

                        books.Insert(index, bookName2);
                        books.Remove(bookName);

                        books.Insert(index2, oldBook);
                        books.RemoveAt(index2 + 1);

                    }
                }

                else if (cmndArgs[0] == "Insert Book")
                {
                    string bookName = cmndArgs[1];
                    books.Add(bookName);
                }
                else if (cmndArgs[0] == "Check Book")
                {
                    int index = int.Parse(cmndArgs[1]);

                    if (index >= 0 && index <= books.Count)
                    {
                        Console.WriteLine($"{books[index]}");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", books));
        }
    }
}
