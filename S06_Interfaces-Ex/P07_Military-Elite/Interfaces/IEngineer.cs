using MilitaryElite.Models;

namespace MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        List<Repair> Repairs { get; }
        void AddRepair(Repair repair);
    }
}
