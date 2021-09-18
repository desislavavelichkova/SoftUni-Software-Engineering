using System;
using System.Text.RegularExpressions;

namespace _2.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                string pattern = @"@#{1,}([A-Z][A-Za-z0-9]{4,}[A-Z])@#{1,}";
                
                Match matchedBarcode = Regex.Match(barcode, pattern);               

                if (!matchedBarcode.Success)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {
                        string digits = "";

                        for (int j = 0; j < matchedBarcode.Value.Length; j++)
                        {
                            if (char.IsDigit(matchedBarcode.Value[j]))
                            {
                                digits += matchedBarcode.Value[j];
                            }
                        }

                    if (digits == "")
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    { 
                        Console.WriteLine($"Product group: {digits}");                        
                    }
                    
                }
            }
        }
    }
}
