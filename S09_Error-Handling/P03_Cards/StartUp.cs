namespace Cards
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cards = new List<Card>();
            var tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var token in tokens)
            {
                var cardTokens = token.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string face = cardTokens[0];
                string suit = cardTokens[1];

                try
                {
                    Card card = new Card(face, suit);
                    cards.Add(card);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            Console.WriteLine(string.Join(" ", cards));
        }
    }
    public class Card
    {
        private static string[] validCardFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private static string[] validCardSuits = { "S", "H", "D", "C" };
        private static Dictionary<string, string> suitsUTF = new() {
            {"S", "\u2660" },
            {"H", "\u2665" },
            {"D", "\u2666" },
            {"C", "\u2663" },
        };
        private const string errorMessage = "Invalid card!";

        private string _face;
        private string _suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get => _face;
            set
            {
                if (!validCardFaces.Contains(value))
                    throw new ArgumentException(errorMessage);
                _face = value;
            }
        }

        public string Suit
        {
            get => _suit;
            set
            {
                if (!validCardSuits.Contains(value))
                    throw new ArgumentException(errorMessage);
                _suit = value;
            }
        }

        public override string ToString() => $"[{Face}{suitsUTF[Suit]}]";
    }
}
