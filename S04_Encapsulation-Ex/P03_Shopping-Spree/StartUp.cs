using ShoppingSpree.Models;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            char[] delims = { '=', ';' };

            var people = new List<Person>();
            string[] peopleTokens = Console.ReadLine()
                .Split(delims, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 1; i < peopleTokens.Length; i += 2)
            {
                try
                {
                    var person = new Person(peopleTokens[i - 1], double.Parse(peopleTokens[i]));
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            var products = new List<Product>();
            string[] productTokens = Console.ReadLine()
                .Split(delims, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 1; i < productTokens.Length; i += 2)
            {
                try
                {
                    var product = new Product(productTokens[i - 1], double.Parse(productTokens[i]));
                    products.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                string[] tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string personName = tokens[0];
                string productNmae = tokens[1];

                var person = people.Where(p => p.Name == personName).FirstOrDefault();
                var product = products.Where(p => p.Name == productNmae).FirstOrDefault();

                person.BuyProduct(product);
            }

            foreach (var person in people)
                Console.WriteLine(person);
        }
    }
}
