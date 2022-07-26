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

            //Infantry has no coalition!
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
            ksSM.BlueStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedRed.FindAll(x => 
            x.PrimaryType.ToLower() != "ship" &&
            x.PrimaryType.ToLower() != "sam/aaa" &&
            x.PrimaryType.ToLower() != "tank" &&
            x.PrimaryType.ToLower() != "helicopter" &&
            x.PrimaryType.ToLower() != "aircraft" &&
            x.PrimaryType.ToLower() != "missile")));

            return ksSM;
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
                    if (unit.SecondaryPilot == string.Empty)
                    {
                        killStatistics.Add(new KillStatistic_ByUnitType() { Destroyed = 1, Coalition = unit.PrimaryCoalition, /*Country = unit.PrimaryCountry,*/ Type = unit.PrimaryType, UnitTypeName = unit.PrimaryUnitTypeName });
                    }
                    else
                    {
                        killStatistics.Add(new KillStatistic_ByUnitType() { Killed = 1, Coalition = unit.PrimaryCoalition, /*Country = unit.PrimaryCountry,*/ Type = unit.PrimaryType, UnitTypeName = unit.PrimaryUnitTypeName });
                    }
                }
                else
                {
                    if (unit.SecondaryPilot == string.Empty)
                    {
                        entry.Destroyed++;
                    }
                    else
                    {
                        entry.Killed++;
                    }
                }
            }

            return killStatistics;
        }
    }
}
