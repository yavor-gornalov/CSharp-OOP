using MilitaryElite.Interfaces;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite;

public class StartUp
{

    static void Main(string[] args)
    {
        var soldiers = new Dictionary<int, ISoldier>();

        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            try
            {
                string[] tokens = line
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string soldierType = tokens[0];
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];

                ISoldier currentSoldier = null;

                switch (soldierType)
                {
                    case "Private":
                        currentSoldier = new Private(id, firstName, lastName, decimal.Parse(tokens[4]));
                        break;

                    case "LieutenantGeneral":
                        var privates = new List<IPrivate>();
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            int soldierId = int.Parse(tokens[i]);
                            Private soldier = (Private)soldiers[soldierId];
                            privates.Add(soldier);
                        }
                        currentSoldier = new LieutenantGeneral(id, firstName, lastName, decimal.Parse(tokens[4]), privates);
                        break;

                    case "Engineer":
                        var repairs = new List<Repair>();
                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            try
                            {
                                string partName = tokens[i];
                                int hoursWorked = int.Parse(tokens[i + 1]);
                                var repair = new Repair(partName, hoursWorked);
                                repairs.Add(repair);
                            }
                            catch (Exception ex) { }
                        }
                        currentSoldier = new Engineer(id, firstName, lastName, decimal.Parse(tokens[4]), tokens[5], repairs);
                        break;

                    case "Commando":
                        var missions = new List<Mission>();
                        for (int i = 6; i < tokens.Length; i += 2)
                        {
                            try
                            {
                                string missionName = tokens[i];
                                string missionState = tokens[i + 1];
                                var mission = new Mission(missionName, missionState);
                                missions.Add(mission);

                            }
                            catch (Exception ex) { }
                        }
                        currentSoldier = new Commando(id, firstName, lastName, decimal.Parse(tokens[4]), tokens[5], missions);
                        break;

                    case "Spy":
                        currentSoldier = new Spy(id, firstName, lastName, int.Parse(tokens[4]));
                        break;
                }

                soldiers.Add(id, currentSoldier);

                Console.WriteLine(currentSoldier);
            }
            catch (Exception ex) { }
        }
    }
}



