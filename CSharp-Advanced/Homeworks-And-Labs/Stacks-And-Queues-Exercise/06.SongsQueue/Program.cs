using System;
using System.Collections.Generic;


namespace _06.SongsQueue
{
    class Program
    {
        public static string Substring { get; private set; }

        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queueOfSongs = new Queue<string>(songs);

            while (queueOfSongs.Count > 0)
            {
                string input = Console.ReadLine();

                if (input == "Play")
                {
                    queueOfSongs.Dequeue();
                }
                else if (input.Substring(0,4) == "Add ")
                {
                    string song = input.Substring(4);
                    if (queueOfSongs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queueOfSongs.Enqueue(song);
                    }
                }
                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ", queueOfSongs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
