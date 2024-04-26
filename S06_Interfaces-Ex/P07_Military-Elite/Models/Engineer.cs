using MilitaryElite.Interfaces;
using System.Reflection;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string corpsName) :
            base(id, firstName, lastName, salary, corpsName)
        {
            Repairs = new List<Repair>();
        }

        public List<Repair> Repairs { get; }

        public void AddRepair(Repair repair) => Repairs.Add(repair);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {CorpsName}");
            sb.AppendLine("Repairs:");
            foreach (var r in Repairs)
                sb.AppendLine("  " + r.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}
