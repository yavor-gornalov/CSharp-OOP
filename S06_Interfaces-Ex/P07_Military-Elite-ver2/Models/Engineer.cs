using MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(
        int id,
        string firstName,
        string lastName,
        decimal salary,
        string corps,
        List<Repair> repairs)
        : base(id, firstName, lastName, salary, corps)
    {
        Repairs = new List<Repair>(repairs);
    }

    public List<Repair> Repairs { get; }

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine(base.ToString());
        sb.AppendLine("Repairs:");

        foreach (var repair in Repairs)
        {
            sb.AppendLine($"  {repair.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}
