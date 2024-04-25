using Telephony.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public void Call(string mobileNumber)
        {
            if (!mobileNumber.All(x => char.IsDigit(x)))
                throw new ArgumentException("Invalid number!");
            Console.WriteLine($"Calling... {mobileNumber}");
        }
        public void Browse(string webSite)
        {
            if (webSite.Any(char.IsDigit))
                throw new ArgumentException("Invalid URL!");
            Console.WriteLine($"Browsing: {webSite}!");
        }
    }
}
