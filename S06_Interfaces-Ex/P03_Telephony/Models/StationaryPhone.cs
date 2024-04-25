using Telephony.Interfaces;

namespace Telephony.Models
{
    public class StationaryPhone : IDailable
    {
        public void Dail(string phoneNumber){
            if (!phoneNumber.All(x => char.IsDigit(x)))
                throw new ArgumentException("Invalid number!");
            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
