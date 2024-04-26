using MilitaryElite.Models;

namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {
        public List<Mission> Missions { get; }
        public void AddMission(Mission mission);
    }
}
