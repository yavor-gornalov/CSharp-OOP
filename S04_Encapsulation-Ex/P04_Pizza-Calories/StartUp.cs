using PizzaCalories.Models;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split().ToArray()[1];

                var doughTokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var dough = new Dough(
                    doughTokens[1],
                    doughTokens[2],
                    double.Parse(doughTokens[3])
                    );
                
                var pizza = new Pizza(pizzaName, dough);

                string line;
                while ((line = Console.ReadLine()) != "END")
                {
                    var tokens = line
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    var topping = new Topping(
                        tokens[1],
                        double.Parse(tokens[2])
                        );

                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
