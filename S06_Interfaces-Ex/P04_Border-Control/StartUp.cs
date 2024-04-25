using BorderControl.Interfaces;
using BorderControl.Models;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Iidentifiable> visitors = new List<Iidentifiable>();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (tokens.Length)
                {
                    case 2:
                        {
                            Iidentifiable robot = new Robot(model: tokens[0], id: tokens[1]);
                            visitors.Add(robot);
                            break;
                        }
                    case 3:
                        {
                            Iidentifiable human = new Human(name: tokens[0], age: int.Parse(tokens[1]), id: tokens[2]);
                            visitors.Add(human);
                            break;
                        }
                }
            }

            string fakeId = Console.ReadLine();

            foreach (Iidentifiable visitor in visitors.Where(v => v.Id.EndsWith(fakeId)))
                visitor.PrintId();
        }
    }
}
