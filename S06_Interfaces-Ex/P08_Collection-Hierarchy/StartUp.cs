using CollectionHierarchy.Models;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var strings = Console.ReadLine().Split().ToList();

            foreach (var s in strings)
                Console.Write(addCollection.Add(s) + " ");
            Console.WriteLine();

            foreach (var s in strings)
                Console.Write(addRemoveCollection.Add(s) + " ");
            Console.WriteLine();

            foreach (var s in strings)
                Console.Write(myList.Add(s) + " ");
            Console.WriteLine();

            int numberOfRemoves = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRemoves; i++)
                Console.Write(addRemoveCollection.Remove() + " ");
            Console.WriteLine();

            for (int i = 0; i < numberOfRemoves; i++)
                Console.Write(myList.Remove() + " ");
            Console.WriteLine();
        }
    }
}
