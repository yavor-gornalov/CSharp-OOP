namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var box = new Box(
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine()),
                    double.Parse(Console.ReadLine())
                );
                Console.WriteLine(box);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
