namespace People
{
    internal class StartUp
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            //Person person = new Person(name, age);
            //Console.WriteLine(person);


            Child child = new Child(name, age);
            Console.WriteLine(child);
        }

    }
}
