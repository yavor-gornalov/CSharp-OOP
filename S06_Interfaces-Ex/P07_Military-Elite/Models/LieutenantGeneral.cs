using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, IEnumerable<Soldier> privates)
            : base(id, firstName, lastName, salary)
        {
            Corps = new List<Soldier>(privates);
        }

        public List<Soldier> Corps { get; private set; }

        public void AddPrivate(Private soldier) => Corps.Add(soldier);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var p in Corps)
                sb.AppendLine("  " + p.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}
