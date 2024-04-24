using FootballTeamGenerator.Models;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var teams = new List<Team>();

            string line;
            while ((line = Console.ReadLine()) != "END")
            {

                var tokens = line.Split(";").ToArray();

                string command = tokens[0];
                string teamName = tokens[1];

                try
                {
                    switch (command)
                    {
                        case "Team":
                            {
                                var team = new Team(teamName);
                                teams.Add(team);
                                break;
                            }
                        case "Add":
                            {
                                var team = GetTeamByName(teams, teamName);

                                var player = new Player(
                                    name: tokens[2],
                                    endurance: int.Parse(tokens[3]),
                                    sprint: int.Parse(tokens[4]),
                                    dribble: int.Parse(tokens[5]),
                                    passing: int.Parse(tokens[6]),
                                    shooting: int.Parse(tokens[7])
                                    );

                                team.AddPlayer(player);
                                break;
                            }
                        case "Remove":
                            {
                                var team = GetTeamByName(teams, teamName);
                                team.RemovePlayer(playerName: tokens[2]);
                                break;
                            }
                        case "Rating":
                            {
                                var team = GetTeamByName(teams, teamName);
                                Console.WriteLine($"{team.Name} - {team.Rating}");
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //try
            //{
            //    var team = new Team("New");
            //    Console.WriteLine(team.Rating);

            //    var first = new Player("Kieran", 75, 85, 84, 92, 67);
            //    var second = new Player("Aaron_Ramsey", 95, 82, 82, 89, 68);
            //    team.AddPlayer(first);
            //    team.AddPlayer(second);
            //    Console.WriteLine(team.Rating);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        private static Team GetTeamByName(List<Team> teams, string teamName)
            => teams.FirstOrDefault(t => t.Name == teamName) ?? throw new Exception($"Team {teamName} does not exist.");
    }
}
