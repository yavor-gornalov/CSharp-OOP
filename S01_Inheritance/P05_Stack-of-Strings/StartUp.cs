namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var customStack = new StackOfStrings();
            Console.WriteLine(customStack.IsEmpty());

            customStack.AddRange(new List<string>() { "asd", "sdf" });
            Console.WriteLine(customStack.IsEmpty());
        }
    }
}
