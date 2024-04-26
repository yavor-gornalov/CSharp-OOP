using System.Collections.Generic;

namespace MilitaryElite.Interfaces;

public interface ILieutenantGeneral : IPrivate
{
    IReadOnlyCollection<IPrivate> Privates { get; }
}
