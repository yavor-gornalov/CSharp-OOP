namespace SumOfIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().ToArray();

            double sum = 0;
            foreach (var element in arr)
            {
                try
                {
                    int number = int.Parse(element);
                    sum += number;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
