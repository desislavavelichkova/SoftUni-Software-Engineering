using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneData = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] webData = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone phone = new StationaryPhone();

            foreach(var number in phoneData)
            {
                try
                {             
                    if (number.Length == 7)
                    {
                        string result = phone.Call(number);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        string result = smartPhone.Call(number);
                        Console.WriteLine(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
            }

            foreach (var url in webData)
            {
                try
                {                   
                    string result = smartPhone.Browsing(url);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
