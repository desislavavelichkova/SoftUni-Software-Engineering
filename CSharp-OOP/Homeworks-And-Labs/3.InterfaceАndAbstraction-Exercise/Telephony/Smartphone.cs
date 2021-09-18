using System;
using System.Linq;

namespace Telephony
{
    public class SmartPhone : Phone, IBrowsable
    {
        public override string Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
            return $"Calling... {number}";
        }
        public string Browsing(string webSide)
        {
            if (webSide.Any(x => char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid URL!");
            }
            return $"Browsing: {webSide}!";
        }
    }
}

