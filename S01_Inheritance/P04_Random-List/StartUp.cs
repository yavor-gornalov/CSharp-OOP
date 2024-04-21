namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var randomList = new RandomList() { "asd", "sdd", "rmw", "ppo", "rhe" };

            Console.WriteLine(randomList.RemoveRandomElement());
            Console.WriteLine(randomList.RemoveRandomElement());
            Console.WriteLine(randomList.RemoveRandomElement());
            Console.WriteLine(randomList.RandomString());
            Console.WriteLine(randomList.RandomString());
        }
    }
}
