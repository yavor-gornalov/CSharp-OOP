namespace PlayCatch
{
    public class Program
    {
        public static List<int> numbers;
        static void Main(string[] args)
        {
            numbers = new List<int>();
            int exceptionCounter = 0;

            Console.ReadLine().Split().ToList().ForEach(n =>
            {
                try
                {
                    numbers.Add(int.Parse(n));
                }
                catch (Exception ex)
                {
                    PrintExceptionMsg(ex);
                    exceptionCounter++;
                }
            });

            if (exceptionCounter >= 3) return;

            while (exceptionCounter < 3)
            {
                var commandTokens = Console.ReadLine().Split().ToArray();
                string command = commandTokens[0];

                try
                {
                    switch (command)
                    {
                        case "Replace": { Replace(commandTokens[1..]); break; }
                        case "Print": { Print(commandTokens[1..]); break; }
                        case "Show": { Show(commandTokens[1..]); break; }
                    }
                }
                catch (Exception ex)
                {
                    PrintExceptionMsg(ex);
                    exceptionCounter++;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void PrintExceptionMsg(Exception ex)
        {
            string message = string.Empty;
            switch (ex.GetType().Name)
            {
                case "ArgumentOutOfRangeException":
                case "ArgumentException": { message = "The index does not exist!"; break; }
                case "FormatException": { message = "The variable is not in the correct format!"; break; }
                default: { message = ex.Message; break; }
            }
            Console.WriteLine(message);

        }

        private static void Show(string[] tokens)
        {
            int idx = int.Parse(tokens[0]);
            Console.WriteLine(numbers[idx]);
        }

        private static void Print(string[] tokens)
        {
            var startIdx = int.Parse(tokens[0]);
            int endIdx = int.Parse(tokens[1]);
            Console.WriteLine(string.Join(", ", numbers.GetRange(startIdx, endIdx - startIdx + 1)));
        }

        private static void Replace(string[] tokens)
        {
            int idx = int.Parse(tokens[0]);
            int element = int.Parse(tokens[1]);
            numbers[idx] = element;
        }
    }
}
