
namespace EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbers(start: 1, end: 100, count: 10);
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static int[] ReadNumbers(int start, int end, int count)
        {
            var numbers = new List<int>(count);

            while (numbers.Count < count)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number <= start || number >= end)
                        throw new ArgumentOutOfRangeException();
                    numbers.Add(number);
                    start = number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {start} - {end}!");
                }
            }
            return numbers.ToArray();
        }
    }
}
