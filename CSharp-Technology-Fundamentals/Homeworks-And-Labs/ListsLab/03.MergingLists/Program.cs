using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            List<int> secondList = Console.ReadLine()
                                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            List<int> resultList = new List<int>();
            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }
                                  
            for (int i = Math.Min(firstList.Count, secondList.Count); i < Math.Max(firstList.Count, secondList.Count); i++)
            {
                if (i >= firstList.Count)
                {
                    resultList.Add(secondList[i]);
                }
                else
                {
                    resultList.Add(firstList[i]);
                }
            }
            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
