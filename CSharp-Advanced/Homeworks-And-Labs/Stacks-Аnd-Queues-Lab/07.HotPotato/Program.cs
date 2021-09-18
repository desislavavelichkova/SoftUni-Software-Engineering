using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] childrens = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> childrenQueue = new Queue<string>(childrens);
            int potatoCircle = 0;
            
            while (childrenQueue.Count != 1)
            {
                potatoCircle++;
                string kid = childrenQueue.Dequeue();

                if (potatoCircle == n)
                {
                    potatoCircle = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    childrenQueue.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {childrenQueue.Peek()}");
        }

    }
}
