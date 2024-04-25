using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();
            var sites = Console.ReadLine().Split().ToArray();

            var smartPhone = new Smartphone();
            var stationaryPhone = new StationaryPhone();

            foreach (var number in numbers)
            {
                try
                {
                    switch (number.Length)
                    {
                        case 7:
                            {
                                stationaryPhone.Dail(number);
                                break;
                            }
                        case 10:
                            {
                                smartPhone.Call(number);
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var site in sites)
            {
                try
                {
                    smartPhone.Browse(site);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
