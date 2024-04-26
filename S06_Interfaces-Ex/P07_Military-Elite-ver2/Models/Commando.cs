using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(int id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions)
        : base(id, firstName, lastName, salary, corps)
    {
        Missions = new List<Mission>(missions);
    }

    public List<Mission> Missions { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine(base.ToString());
        sb.AppendLine("Missions:");

        foreach (var mission in Missions)
        {
            sb.AppendLine($"  {mission.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}
