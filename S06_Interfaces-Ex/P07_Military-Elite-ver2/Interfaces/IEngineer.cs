using System.Collections.Generic;
using MilitaryElite.Models;

namespace MilitaryElite.Interfaces;
public interface IEngineer : ISpecialisedSoldier
{
    List<Repair> Repairs { get; }
}
