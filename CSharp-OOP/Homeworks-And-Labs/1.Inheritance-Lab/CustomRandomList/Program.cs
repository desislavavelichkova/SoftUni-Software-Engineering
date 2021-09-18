using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add("aaa");
            list.Add("bb");
            list.Add("vvv");
            list.Add("ddd"); 
            list.Add("sss");

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(list.RandomString());

            }
        }
    }
}
