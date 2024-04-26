using MilitaryElite.Interfaces;
using System;
using System.Linq;

namespace MilitaryElite.Models;
public class Mission : IMission
{
    private string[] availableStates = { "inProgress", "Finished" };
    private string _state;

    public Mission(string codeName, string state)
    {
        CodeName = codeName;
        State = state;
    }

    public string CodeName { get; private set; }

    public string State
    {
        get => _state;
        private set
        {
            if (!availableStates.Contains(value))
                throw new ArgumentException("Invalid Mission State!");
            _state = value;
        }
    }

    public void CompleteMission() => State = "Finished";

    public override string ToString()
        => $"Code Name: {CodeName} State: {State}";
}
