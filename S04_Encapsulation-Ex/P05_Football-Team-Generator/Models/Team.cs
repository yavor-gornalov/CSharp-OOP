namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private int rating = 0;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("A name should not be empty.");
                name = value;
            }
        }

        public int Rating { get => CalculateRating(); }

        public void AddPlayer(Player player) => players.Add(player);

        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove == null)
                throw new Exception($"Player {playerName} is not in {Name} team.");
            players.Remove(playerToRemove);

        }

        private int CalculateRating()
        {
            if (players.Count == 0)
                return 0;
            return (int)Math.Round(players.Average(p => PlayerRating(p)), 0, MidpointRounding.AwayFromZero);
        }

        private static decimal PlayerRating(Player player)
        {
            return decimal.Divide((player.Endurance + player.Passing + player.Sprint + player.Dribble + player.Shooting), 5);
        }
    }
}
