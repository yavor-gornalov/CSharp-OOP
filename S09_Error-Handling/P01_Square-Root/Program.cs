namespace SquareRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                    throw new ArgumentException("Invalid number.");
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
