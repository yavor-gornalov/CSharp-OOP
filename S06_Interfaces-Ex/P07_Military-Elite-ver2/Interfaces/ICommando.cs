using System.Collections.Generic;
using MilitaryElite.Models;

namespace MilitaryElite.Interfaces;

public interface ICommando : ISpecialisedSoldier
{
    List<Mission> Missions { get; }
}
