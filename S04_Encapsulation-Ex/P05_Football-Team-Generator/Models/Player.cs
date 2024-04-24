namespace FootballTeamGenerator.Models
{
    public class Player
    {
        private const int MinStatLimit = 0;
        private const int MaxStatLimit = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name; private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new Exception("A name should not be empty.");
                name = value;
            }
        }

        public int Endurance
        {
            get => endurance; private set
            {
                if (value < MinStatLimit || value > MaxStatLimit)
                    throw new Exception(exMessage(nameof(Endurance)));
                endurance = value;
            }
        }

        public int Sprint
        {
            get => sprint; private set
            {
                if (value < MinStatLimit || value > MaxStatLimit)
                    throw new Exception(exMessage(nameof(Sprint)));
                sprint = value;
            }
        }

        public int Dribble
        {
            get => dribble; private set
            {
                if (value < MinStatLimit || value > MaxStatLimit)
                    throw new Exception(exMessage(nameof(Dribble)));
                dribble = value;
            }
        }

        public int Passing
        {
            get => passing; private set
            {
                if (value < MinStatLimit || value > MaxStatLimit)
                    throw new Exception(exMessage(nameof(Passing)));
                passing = value;
            }
        }

        public int Shooting
        {
            get => shooting; private set
            {
                if (value < MinStatLimit || value > MaxStatLimit)
                    throw new Exception(exMessage(nameof(Shooting)));
                shooting = value;
            }
        }

        private string exMessage(string statName)
            => $"{statName} should be between {MinStatLimit} and {MaxStatLimit}.";
    }
}
