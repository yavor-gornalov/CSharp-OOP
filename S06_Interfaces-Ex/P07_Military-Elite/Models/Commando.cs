using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, string corpsName) :
            base(id, firstName, lastName, salary, corpsName)
        {
            Missions = new List<Mission>();
        }
        public List<Mission> Missions { get; }

        public void AddMission(Mission mission) => Missions.Add(mission);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {CorpsName}");
            sb.AppendLine("Missions:");
            foreach (var m in Missions)
                sb.AppendLine("  " + m.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}
