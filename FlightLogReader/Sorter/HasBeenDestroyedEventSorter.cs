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
            ksSM.DestroyedAllies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Allies");
            ksSM.DestroyedEnemies = hbdEvents.FindAll(x => x.PrimaryCoalition == "Enemies");

            ksSM.AlliedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "aircraft")));
            ksSM.AlliedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "helicopter")));
            ksSM.AlliedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "tank")));
            ksSM.AlliedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa")));
            ksSM.AlliedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() == "ship")));
            ksSM.AlliedStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() != "ship" 
                && x.PrimaryType.ToLower() != "sam/aaa" && x.PrimaryType.ToLower() != "tank" && x.PrimaryType.ToLower() != "helicopter" && x.PrimaryType.ToLower() != "aircraft")));

            //***************
            ksSM.EnemyStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "aircraft")));
            ksSM.EnemyStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "helicopter")));
            ksSM.EnemyStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "tank")));
            ksSM.EnemyStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "sam/aaa")));
            ksSM.EnemyStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedEnemies.FindAll(x => x.PrimaryType.ToLower() == "ship")));
            ksSM.EnemyStatistic.Add(CalculateKillStatistic_ByUnitTypeName(ksSM.DestroyedAllies.FindAll(x => x.PrimaryType.ToLower() != "ship"
                && x.PrimaryType.ToLower() != "sam/aaa" && x.PrimaryType.ToLower() != "tank" && x.PrimaryType.ToLower() != "helicopter" && x.PrimaryType.ToLower() != "aircraft")));

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
