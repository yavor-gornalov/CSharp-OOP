using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string[] availableStates = { "inProgress", "Finished" };

        private string _missionState;

        public string CodeName { get; }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public string State
        {
            get => _missionState;
            set
            {
                if (!availableStates.Contains(value))
                    throw new ArgumentException("Invalid mission state!");
                _missionState = value;
            }
        }

        public void CompleteMission() => _missionState = "Finished";

        public override string ToString() => $"Code Name: {CodeName} State: {State}";
    }
}
