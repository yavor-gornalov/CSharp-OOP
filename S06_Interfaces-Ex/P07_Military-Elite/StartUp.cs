using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var soldiers = new List<Soldier>();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                var tokens = line
                    .Split()
                    .ToArray();

                try
                {
                    switch (tokens[0])
                    {

                        case "Private":
                            {
                                var soldier = new Private(
                                    id: int.Parse(tokens[1]),
                                    firstName: tokens[2],
                                    lastName: tokens[3],
                                    salary: decimal.Parse(tokens[4])
                                    );
                                soldiers.Add(soldier);
                                break;
                            }
                        case "LieutenantGeneral":
                            {
                                var privates = new List<Soldier>();
                                var soldierIds = tokens[5..].Select(int.Parse).ToArray();
                                for (int i = 0; i < soldierIds.Length; i++)
                                {
                                    if (soldiers.Where(s => s.GetType() == typeof(Private)).FirstOrDefault(s => s.Id == soldierIds[i]) is Private soldier)
                                        privates.Add(soldier);
                                }

                                var general = new LieutenantGeneral(
                                    id: int.Parse(tokens[1]),
                                    firstName: tokens[2],
                                    lastName: tokens[3],
                                    salary: decimal.Parse(tokens[4]),
                                    privates: privates
                                    );

                                soldiers.Add(general);
                                break;
                            }
                        case "Engineer":
                            {
                                var engineer = new Engineer(
                                    id: int.Parse(tokens[1]),
                                    firstName: tokens[2],
                                    lastName: tokens[3],
                                    salary: decimal.Parse(tokens[4]),
                                    corpsName: tokens[5]);

                                var partsTokens = tokens[6..];
                                for (int i = 1; i < partsTokens.Length; i += 2)
                                {
                                    string part = partsTokens[i - 1];
                                    int hours = int.Parse(partsTokens[i]);
                                    try
                                    {
                                        var repair = new Repair(part, hours);
                                        engineer.AddRepair(repair);
                                    }
                                    catch (Exception ex)
                                    {
                                        continue;
                                    }
                                }

                                soldiers.Add(engineer);
                                break;
                            }
                        case "Commando":
                            {
                                var commando = new Commando(
                                    id: int.Parse(tokens[1]),
                                    firstName: tokens[2],
                                    lastName: tokens[3],
                                    salary: decimal.Parse(tokens[4]),
                                    corpsName: tokens[5]
                                    );

                                var missionTokens = tokens[6..];
                                for (int i = 1; i < missionTokens.Length; i += 2)
                                {
                                    string codeName = missionTokens[i - 1];
                                    string state = missionTokens[i];
                                    try
                                    {
                                        var mission = new Mission(codeName, state);
                                        commando.AddMission(mission);
                                    }
                                    catch (Exception ex)
                                    {
                                        continue;
                                    }
                                }

                                soldiers.Add(commando);
                                break;
                            }
                        case "Spy":
                            {
                                var spy = new Spy(
                                    id: int.Parse(tokens[1]),
                                    firstName: tokens[2],
                                    lastName: tokens[3],
                                    codeNumber: int.Parse(tokens[4])
                                    );
                                break;
                            }
                    }
                }
                catch (Exception ex) { continue; }
            }
            foreach (var soldier in soldiers)
                Console.WriteLine(soldier);
        }
    }
}
