using MilitaryElite.Interfaces;
using System;
using System.Linq;

namespace MilitaryElite.Models;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private readonly string[] availableCorpsNames = { "Airforces", "Marines" };
    private string _corps;

    protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        Corps = corps;
    }

    public string Corps { 
        get => _corps;
        private set
        {
            if (!availableCorpsNames.Contains(value))
                throw new ArgumentException("Invalid Corps Type!");
            _corps = value;
        } }

    public override string ToString()
        => base.ToString() + $"{Environment.NewLine}Corps: {Corps}";
}
