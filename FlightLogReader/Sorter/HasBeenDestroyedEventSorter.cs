using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade;

namespace FlightLogReader.Sorter
{
    public static class HasBeenDestroyedEventSorter
    {
        public static KillStatisticSingleMission Sort(List<HasBeenDestroyedEvent> hbdEvents)
        {
            var ksSM = new KillStatisticSingleMission();

            //Missile -> HasBeenfired
            ksSM.DestroyedRed = hbdEvents.FindAll(x => x.PrimaryCoalition == "Allies");
            ksSM.DestroyedBlue = hbdEvents.FindAll(x => x.PrimaryCoalition == "Enemies");

            ksSM.RedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedRed.FindAll(x => x.PrimaryType.ToLower() == "aircraft")));
            ksSM.RedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedRed.FindAll(x => x.PrimaryType.ToLower() == "helicopter")));
            ksSM.RedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedRed.FindAll(x => x.PrimaryType.ToLower() == "tank")));
            ksSM.RedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedRed.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa")));
            ksSM.RedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedRed.FindAll(x => x.PrimaryType.ToLower() == "ship")));
            ksSM.RedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedRed.FindAll(x => 
            x.PrimaryType.ToLower() != "ship" && 
            x.PrimaryType.ToLower() != "sam/aaa" && 
            x.PrimaryType.ToLower() != "tank" && 
            x.PrimaryType.ToLower() != "helicopter" && 
            x.PrimaryType.ToLower() != "aircraft" &&
            x.PrimaryType.ToLower() != "missile")));

            //***************
            ksSM.BlueStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedBlue.FindAll(x => x.PrimaryType.ToLower() == "aircraft")));
            ksSM.BlueStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedBlue.FindAll(x => x.PrimaryType.ToLower() == "helicopter")));
            ksSM.BlueStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedBlue.FindAll(x => x.PrimaryType.ToLower() == "tank")));
            ksSM.BlueStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedBlue.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa")));
            ksSM.BlueStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedBlue.FindAll(x => x.PrimaryType.ToLower() == "ship")));
            ksSM.BlueStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedBlue.FindAll(x => 
            x.PrimaryType.ToLower() != "ship" &&
            x.PrimaryType.ToLower() != "sam/aaa" &&
            x.PrimaryType.ToLower() != "tank" &&
            x.PrimaryType.ToLower() != "helicopter" &&
            x.PrimaryType.ToLower() != "aircraft" &&
            x.PrimaryType.ToLower() != "missile")));

            return ksSM;
        }

        public static KillStatisticSingleMission MergeMissions(KillStatisticSingleMission mission1, KillStatisticSingleMission mission2)
        {
            var allHasBeenDestroyedEvents = mission1.DestroyedBlue.Concat(mission1.DestroyedRed).Concat(mission2.DestroyedBlue).Concat(mission2.DestroyedRed);

            var statistic = Sort(allHasBeenDestroyedEvents.ToList());
            return statistic;
        }

        //KIA, TODO: MIA
        private static List<KillStatistic_ByUnitType> CalculateKillStatistic_ByUnitTypeName(List<HasBeenDestroyedEvent> list)
        {
            var killStatistics = new List<KillStatistic_ByUnitType>();

            foreach (var unit in list)
            {
                var entry = killStatistics.FirstOrDefault(x => x.UnitTypeName == unit.PrimaryUnitTypeName);
                if (entry == null)
                {
                    var killStatistic = new KillStatistic_ByUnitType();
                    if (unit.PlayerKill)
                        killStatistic.PlayerKills++;

                    if (unit.PlayerDeath)
                        killStatistic.PlayerDeaths++;

                    if (unit.SecondaryPilot == string.Empty)
                    {
                        killStatistic.Destroyed = 1; killStatistic.Coalition = unit.PrimaryCoalition; killStatistic.Type = unit.PrimaryType; killStatistic.Type = unit.PrimaryType; killStatistic.UnitTypeName = unit.PrimaryUnitTypeName;
                        killStatistics.Add(killStatistic);
                    }
                    else
                    {
                        killStatistic.Killed = 1; killStatistic.Coalition = unit.PrimaryCoalition; killStatistic.Type = unit.PrimaryType; killStatistic.Type = unit.PrimaryType; killStatistic.UnitTypeName = unit.PrimaryUnitTypeName;
                        killStatistics.Add(killStatistic);
                    }
                }
                else
                {
                    if (unit.PlayerKill)
                        entry.PlayerKills++;

                    if (unit.PlayerDeath)
                        entry.PlayerDeaths++;

                    if (unit.SecondaryPilot == string.Empty)
                        entry.Destroyed++;
                    else
                        entry.Killed++;
                }
            }

            return killStatistics;
        }
    }
}
